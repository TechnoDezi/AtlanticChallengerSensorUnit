#include <OneWire.h>
#include <DallasTemperature.h>
#include <ArduinoJson.h>
#include <SPI.h>
#include <RH_RF95.h>

//------------------------------------------------
const int tmp1Pin = 11;
const int tmp2Pin = 12;
const int rpm1Pin = 6;
const int rpm2Pin = 10;
const int cur1Pin = 19;
const int cur2Pin = 20;
//-----------------------------------------------

#define V_REF 1100
unsigned long prevmillis1; // To store time
unsigned long prevmillis2;
unsigned long duration1; // To store time difference
unsigned long duration2;
unsigned long refresh; // To store time for refresh of reading

boolean currentstate1; // Current state of IR input scan
boolean prevstate1; // State of IR sensor in previous scan
boolean currentstate2;
boolean prevstate2;
int mVperAmp1 = 10;
int mVperAmp2 = 10;
int ACSoffset1 = 2500;
int ACSoffset2 = 2500;

#define TEMP1_BUS tmp1Pin
#define TEMP2_BUS tmp2Pin
#define TEMPERATURE_PRECISION 12 // Lower resolution
OneWire oneWireTemp1(TEMP1_BUS);
OneWire oneWireTemp2(TEMP2_BUS);
DallasTemperature sensorsTemp1(&oneWireTemp1);
DallasTemperature sensorsTemp2(&oneWireTemp2);
int numberOfDevicesTemp1; // Number of temperature devices found
int numberOfDevicesTemp2;
DeviceAddress temp1DeviceAddress; // We'll use this variable to store a found device address
DeviceAddress temp2DeviceAddress;

#define RFM95_CS 8
#define RFM95_RST 4
#define RFM95_INT 7
#define RF95_FREQ 915.0
RH_RF95 rf95(RFM95_CS, RFM95_INT);
unsigned long transmitDelay;
int16_t packetnum = 0;

float tmp1Celciaus = 0;
float tmp2Celciaus = 0;
int rpm1;
int rpm2;
double Amps1 = 0;
double Amps2 = 0;
double Voltage1 = 0;
double VRMS1 = 0;
double Voltage2 = 0;
double VRMS2 = 0;
int ARead1 = 0;
int ARead2 = 0;

void setup()
{
  Serial.begin(9600);

  setupLora();
  setupSensors();
  delay(5000);
}

void setupLora()
{
  while (!rf95.init()) {
    Serial.println("LoRa radio init failed");
    while (1);
  }
  Serial.println("LoRa radio init OK!");

  // Defaults after init are 434.0MHz, modulation GFSK_Rb250Fd250, +13dbM
  if (!rf95.setFrequency(RF95_FREQ)) {
    Serial.println("setFrequency failed");
    while (1);
  }
  Serial.print("Set Freq to: "); Serial.println(RF95_FREQ);

  rf95.setTxPower(23, false);
}

void setupSensors()
{
  Serial.println("Setup sensors");
  
pinMode(cur1Pin,INPUT);
pinMode(cur2Pin,INPUT);
  
  prevmillis1 = 0;
  prevstate1 = LOW;
  prevmillis2 = 0;
  prevstate2 = LOW;

  sensorsTemp1.begin();
  sensorsTemp2.begin();
  numberOfDevicesTemp1 = sensorsTemp1.getDeviceCount();
  numberOfDevicesTemp2 = sensorsTemp2.getDeviceCount();

  for (int i = 0; i < numberOfDevicesTemp1; i++)
  {
    // Search the wire for address
    if (sensorsTemp1.getAddress(temp1DeviceAddress, i))
    {
      // set the resolution to TEMPERATURE_PRECISION bit (Each Dallas/Maxim device is capable of several different resolutions)
      sensorsTemp1.setResolution(temp1DeviceAddress, TEMPERATURE_PRECISION);
    }
  }
  for (int i = 0; i < numberOfDevicesTemp2; i++)
  {
    // Search the wire for address
    if (sensorsTemp2.getAddress(temp2DeviceAddress, i))
    {
      // set the resolution to TEMPERATURE_PRECISION bit (Each Dallas/Maxim device is capable of several different resolutions)
      sensorsTemp2.setResolution(temp2DeviceAddress, TEMPERATURE_PRECISION);
    }
  }
}

void loop()
{
  getSensorValues();
  transmitSensorValues();
}

void transmitSensorValues()
{
  if ( ( millis() - transmitDelay ) >= 500 )
  {
    Serial.println("Transmitting...");

    char radiopacket[200];

    StaticJsonBuffer<200> jsonBuffer;
    JsonObject& root = jsonBuffer.createObject();
    root["temp1"] = tmp1Celciaus;
    root["temp2"] = tmp2Celciaus;
    root["rpm1"] = rpm1;
    root["rpm2"] = rpm2;
    String output;
    root.printTo(radiopacket);

    itoa(packetnum++, radiopacket + 200, 10);
    Serial.print("Sending: "); Serial.println(radiopacket);

    rf95.send((uint8_t *)radiopacket, 200);

    Serial.println("Waiting for packet to complete...");

    rf95.waitPacketSent();
    
    Serial.println("Sent");
    
    transmitDelay = millis();
  }
}

void getSensorValues()
{
  // RPM 1 Measurement
  currentstate1 = digitalRead(rpm1Pin); // Read IR sensor state
  if ( prevstate1 != currentstate1) // If there is change in input
  {
    if ( currentstate1 == HIGH ) // If input only changes from LOW to HIGH
    {
      duration1 = ( micros() - prevmillis1 ); // Time difference between revolution in microsecond
      rpm1 = (60000000 / duration1); // rpm = (1/ time millis)*1000*1000*60;
      prevmillis1 = micros(); // store time for nect revolution calculation
    }
  }
  prevstate1 = currentstate1; // store this scan (prev scan) data for next scan

  // RPM 2 Measurement
  currentstate2 = digitalRead(rpm2Pin); // Read IR sensor state
  if ( prevstate2 != currentstate2) // If there is change in input
  {
    if ( currentstate2 == HIGH ) // If input only changes from LOW to HIGH
    {
      duration2 = ( micros() - prevmillis2 ); // Time difference between revolution in microsecond
      rpm2 = (60000000 / duration2); // rpm = (1/ time millis)*1000*1000*60;
      prevmillis2 = micros(); // store time for nect revolution calculation
    }
  }
  prevstate2 = currentstate2; // store this scan (prev scan) data for next scan

  //Temperature measurement
  if ( ( millis() - refresh ) >= 3000 )
  {
    sensorsTemp1.requestTemperatures();
    sensorsTemp2.requestTemperatures();

    numberOfDevicesTemp1 = sensorsTemp1.getDeviceCount();
    numberOfDevicesTemp2 = sensorsTemp2.getDeviceCount();
    for (int i = 0; i < numberOfDevicesTemp1; i++)
    {
      // Search the wire for address
      if (sensorsTemp1.getAddress(temp1DeviceAddress, i))
      {
        // It responds almost immediately. Let's print out the data
        printTemperature(temp1DeviceAddress, i); // Use a simple function to print out the data
      }
    }
    for (int i = 0; i < numberOfDevicesTemp2; i++)
    {
      // Search the wire for address
      if (sensorsTemp2.getAddress(temp2DeviceAddress, i))
      {
        // It responds almost immediately. Let's print out the data
        printTemperature2(temp2DeviceAddress, i); // Use a simple function to print out the data
      }
    }

    //Current Measurement
//    Voltage1 = getVPP1();
//    VRMS1 = (Voltage1/2.0) *0.707; 
//    Amps1 = (VRMS1 * 1000)/mVperAmp1;
//
//    Voltage2 = getVPP2();
//    VRMS2 = (Voltage2/2.0) *0.707; 
//    Amps2 = (VRMS2 * 1000)/mVperAmp2;

    refresh = millis();
  }
}

void printTemperature(DeviceAddress deviceAddress, int index)
{
  tmp1Celciaus = sensorsTemp1.getTempC(deviceAddress);
}
void printTemperature2(DeviceAddress deviceAddress, int index)
{
  tmp2Celciaus = sensorsTemp2.getTempC(deviceAddress);
}
