using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenger.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DetectAvailableDevices();
        }

        private void DetectAvailableDevices()
        {
            cbDevice.Items.Clear();

            string[] serialPorts = SerialPort.GetPortNames();
            List<Device> devices = new List<Device>();

            foreach (string port in serialPorts)
            {
                ManagementScope connectionScope = new ManagementScope();
                SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(" + port + "%'");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

                //Try get arduino com ports
                try
                {
                    foreach (ManagementObject item in searcher.Get())
                    {
                        string desc = item["Description"].ToString();
                        string deviceId = port;

                        devices.Add(new Device()
                        {
                            COMPort = deviceId,
                            Description = $"{desc} ({deviceId})"
                        });
                    }
                }
                catch (ManagementException e)
                {
                    /* Do Nothing */
                }
            }

            if (devices.Count > 0)
            {
                cbDevice.DisplayMember = "Description";
                cbDevice.ValueMember = "COMPort";
                cbDevice.DataSource = devices;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DetectAvailableDevices();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort(cbDevice.SelectedValue.ToString(), 9600, Parity.None, 8, StopBits.One);

            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.ErrorReceived += Port_ErrorReceived;
            port.DtrEnable = true;
            // Begin communications 
            port.Open();
        }

        private void Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            //textBox1.Invoke(new Action(() =>
            //{
            //    textBox1.Text += .ToString() + Environment.NewLine;
            //    textBox1.SelectionStart = textBox1.TextLength;
            //    textBox1.ScrollToCaret();
            //}));
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string jsonString = ((SerialPort)sender).ReadLine();
            jsonString = jsonString.Replace("{", "");
            jsonString = jsonString.Replace("}", "");
            jsonString = jsonString.Replace("\"", "");
            jsonString = jsonString.Replace("\r", "");
            jsonString = jsonString.Replace("\n", "");

            try
            {
                string rpm1Value = "0";
                string rpm2Value = "0";
                string temp1Value = "0";
                string temp2Value = "0";

                var objList = jsonString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                foreach(var item in objList)
                {
                    var splitObj = item.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                    if(splitObj.Length == 2)
                    {
                        switch(splitObj[0])
                        {
                            case "rpm1":
                                rpm1Value = splitObj[1]; break;
                            case "rpm2":
                                rpm2Value = splitObj[1]; break;
                            case "temp1":
                                temp1Value = splitObj[1]; break;
                            case "temp2":
                                temp2Value = splitObj[1]; break;
                        }
                    }
                }

                rpm1.Invoke(new Action(() => {
                    rpm1.Value = float.Parse(rpm1Value);
                }));

                rpm2.Invoke(new Action(() => {
                    rpm2.Value = float.Parse(rpm2Value);
                }));

                temp1.Invoke(new Action(() => {
                    temp1.Value = float.Parse(temp1Value);
                }));

                temp2.Invoke(new Action(() => {
                    temp2.Value = float.Parse(temp2Value);
                }));
            }
            catch (Exception ex) {
                textBox1.Invoke(new Action(() =>
                {
                    textBox1.Text += ex.ToString() + Environment.NewLine;
                    textBox1.SelectionStart = textBox1.TextLength;
                    textBox1.ScrollToCaret();
                }));
            }

            textBox1.Invoke(new Action(() =>
            {
                textBox1.Text += jsonString + Environment.NewLine;
                
                if (textBox1.Lines.Length > 50)
                {
                    textBox1.Lines = textBox1.Lines.Skip(textBox1.Lines.Length - 50).ToArray();
                }

                textBox1.SelectionStart = textBox1.TextLength;
                textBox1.ScrollToCaret();
            }));
        }
    }

    public class Device
    {
        public string COMPort { get; set; }
        public string Description { get; set; }
    }
}
