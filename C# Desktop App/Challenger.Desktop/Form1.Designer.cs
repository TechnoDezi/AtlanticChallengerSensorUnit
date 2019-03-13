namespace Challenger.Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel4 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange6 = new System.Windows.Forms.AGaugeRange();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.rpm1 = new System.Windows.Forms.AGauge();
            this.rpm2 = new System.Windows.Forms.AGauge();
            this.temp2 = new System.Windows.Forms.AGauge();
            this.temp1 = new System.Windows.Forms.AGauge();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device:";
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(62, 6);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(222, 21);
            this.cbDevice.TabIndex = 1;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(290, 4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(106, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(402, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // rpm1
            // 
            this.rpm1.BaseArcColor = System.Drawing.Color.Gray;
            this.rpm1.BaseArcRadius = 80;
            this.rpm1.BaseArcStart = 135;
            this.rpm1.BaseArcSweep = 270;
            this.rpm1.BaseArcWidth = 2;
            this.rpm1.Center = new System.Drawing.Point(120, 100);
            aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel1.Text = "RPM 1";
            this.rpm1.GaugeLabels.Add(aGaugeLabel1);
            aGaugeRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            aGaugeRange1.EndValue = 12000F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 9000F;
            aGaugeRange2.Color = System.Drawing.Color.Red;
            aGaugeRange2.EndValue = 15000F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange2";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 12000F;
            this.rpm1.GaugeRanges.Add(aGaugeRange1);
            this.rpm1.GaugeRanges.Add(aGaugeRange2);
            this.rpm1.Location = new System.Drawing.Point(15, 57);
            this.rpm1.MaxValue = 15000F;
            this.rpm1.MinValue = 0F;
            this.rpm1.Name = "rpm1";
            this.rpm1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.rpm1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.rpm1.NeedleRadius = 80;
            this.rpm1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.rpm1.NeedleWidth = 2;
            this.rpm1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.rpm1.ScaleLinesInterInnerRadius = 73;
            this.rpm1.ScaleLinesInterOuterRadius = 80;
            this.rpm1.ScaleLinesInterWidth = 1;
            this.rpm1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.rpm1.ScaleLinesMajorInnerRadius = 70;
            this.rpm1.ScaleLinesMajorOuterRadius = 80;
            this.rpm1.ScaleLinesMajorStepValue = 1000F;
            this.rpm1.ScaleLinesMajorWidth = 2;
            this.rpm1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.rpm1.ScaleLinesMinorInnerRadius = 75;
            this.rpm1.ScaleLinesMinorOuterRadius = 80;
            this.rpm1.ScaleLinesMinorTicks = 9;
            this.rpm1.ScaleLinesMinorWidth = 1;
            this.rpm1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.rpm1.ScaleNumbersFormat = null;
            this.rpm1.ScaleNumbersRadius = 95;
            this.rpm1.ScaleNumbersRotation = 0;
            this.rpm1.ScaleNumbersStartScaleLine = 0;
            this.rpm1.ScaleNumbersStepScaleLines = 1;
            this.rpm1.Size = new System.Drawing.Size(248, 199);
            this.rpm1.TabIndex = 6;
            this.rpm1.Text = "RPM 1";
            this.rpm1.Value = 0F;
            // 
            // rpm2
            // 
            this.rpm2.BaseArcColor = System.Drawing.Color.Gray;
            this.rpm2.BaseArcRadius = 80;
            this.rpm2.BaseArcStart = 135;
            this.rpm2.BaseArcSweep = 270;
            this.rpm2.BaseArcWidth = 2;
            this.rpm2.Center = new System.Drawing.Point(120, 100);
            aGaugeLabel2.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel2.Name = "GaugeLabel1";
            aGaugeLabel2.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel2.Text = "RPM 2";
            this.rpm2.GaugeLabels.Add(aGaugeLabel2);
            aGaugeRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            aGaugeRange3.EndValue = 12000F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRange1";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 9000F;
            aGaugeRange4.Color = System.Drawing.Color.Red;
            aGaugeRange4.EndValue = 15000F;
            aGaugeRange4.InnerRadius = 70;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "GaugeRange2";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = 12000F;
            this.rpm2.GaugeRanges.Add(aGaugeRange3);
            this.rpm2.GaugeRanges.Add(aGaugeRange4);
            this.rpm2.Location = new System.Drawing.Point(269, 57);
            this.rpm2.MaxValue = 15000F;
            this.rpm2.MinValue = 0F;
            this.rpm2.Name = "rpm2";
            this.rpm2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.rpm2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.rpm2.NeedleRadius = 80;
            this.rpm2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.rpm2.NeedleWidth = 2;
            this.rpm2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.rpm2.ScaleLinesInterInnerRadius = 73;
            this.rpm2.ScaleLinesInterOuterRadius = 80;
            this.rpm2.ScaleLinesInterWidth = 1;
            this.rpm2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.rpm2.ScaleLinesMajorInnerRadius = 70;
            this.rpm2.ScaleLinesMajorOuterRadius = 80;
            this.rpm2.ScaleLinesMajorStepValue = 1000F;
            this.rpm2.ScaleLinesMajorWidth = 2;
            this.rpm2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.rpm2.ScaleLinesMinorInnerRadius = 75;
            this.rpm2.ScaleLinesMinorOuterRadius = 80;
            this.rpm2.ScaleLinesMinorTicks = 9;
            this.rpm2.ScaleLinesMinorWidth = 1;
            this.rpm2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.rpm2.ScaleNumbersFormat = null;
            this.rpm2.ScaleNumbersRadius = 95;
            this.rpm2.ScaleNumbersRotation = 0;
            this.rpm2.ScaleNumbersStartScaleLine = 0;
            this.rpm2.ScaleNumbersStepScaleLines = 1;
            this.rpm2.Size = new System.Drawing.Size(248, 199);
            this.rpm2.TabIndex = 7;
            this.rpm2.Text = "RPM 1";
            this.rpm2.Value = 0F;
            // 
            // temp2
            // 
            this.temp2.BaseArcColor = System.Drawing.Color.Gray;
            this.temp2.BaseArcRadius = 80;
            this.temp2.BaseArcStart = 180;
            this.temp2.BaseArcSweep = 180;
            this.temp2.BaseArcWidth = 2;
            this.temp2.Center = new System.Drawing.Point(120, 100);
            aGaugeLabel3.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel3.Name = "GaugeLabel1";
            aGaugeLabel3.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel3.Text = "Temp 2";
            this.temp2.GaugeLabels.Add(aGaugeLabel3);
            aGaugeRange5.Color = System.Drawing.Color.Red;
            aGaugeRange5.EndValue = 100F;
            aGaugeRange5.InnerRadius = 70;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "GaugeRange1";
            aGaugeRange5.OuterRadius = 80;
            aGaugeRange5.StartValue = 80F;
            this.temp2.GaugeRanges.Add(aGaugeRange5);
            this.temp2.Location = new System.Drawing.Point(269, 262);
            this.temp2.MaxValue = 100F;
            this.temp2.MinValue = 0F;
            this.temp2.Name = "temp2";
            this.temp2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.temp2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.temp2.NeedleRadius = 80;
            this.temp2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.temp2.NeedleWidth = 2;
            this.temp2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.temp2.ScaleLinesInterInnerRadius = 73;
            this.temp2.ScaleLinesInterOuterRadius = 80;
            this.temp2.ScaleLinesInterWidth = 1;
            this.temp2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.temp2.ScaleLinesMajorInnerRadius = 70;
            this.temp2.ScaleLinesMajorOuterRadius = 80;
            this.temp2.ScaleLinesMajorStepValue = 10F;
            this.temp2.ScaleLinesMajorWidth = 2;
            this.temp2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.temp2.ScaleLinesMinorInnerRadius = 75;
            this.temp2.ScaleLinesMinorOuterRadius = 80;
            this.temp2.ScaleLinesMinorTicks = 9;
            this.temp2.ScaleLinesMinorWidth = 1;
            this.temp2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.temp2.ScaleNumbersFormat = null;
            this.temp2.ScaleNumbersRadius = 95;
            this.temp2.ScaleNumbersRotation = 0;
            this.temp2.ScaleNumbersStartScaleLine = 0;
            this.temp2.ScaleNumbersStepScaleLines = 1;
            this.temp2.Size = new System.Drawing.Size(248, 199);
            this.temp2.TabIndex = 9;
            this.temp2.Text = "RPM 1";
            this.temp2.Value = 0F;
            // 
            // temp1
            // 
            this.temp1.BaseArcColor = System.Drawing.Color.Gray;
            this.temp1.BaseArcRadius = 80;
            this.temp1.BaseArcStart = 180;
            this.temp1.BaseArcSweep = 180;
            this.temp1.BaseArcWidth = 2;
            this.temp1.Center = new System.Drawing.Point(120, 100);
            aGaugeLabel4.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel4.Name = "GaugeLabel1";
            aGaugeLabel4.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel4.Text = "Temp 1";
            this.temp1.GaugeLabels.Add(aGaugeLabel4);
            aGaugeRange6.Color = System.Drawing.Color.Red;
            aGaugeRange6.EndValue = 100F;
            aGaugeRange6.InnerRadius = 70;
            aGaugeRange6.InRange = false;
            aGaugeRange6.Name = "GaugeRange1";
            aGaugeRange6.OuterRadius = 80;
            aGaugeRange6.StartValue = 80F;
            this.temp1.GaugeRanges.Add(aGaugeRange6);
            this.temp1.Location = new System.Drawing.Point(15, 262);
            this.temp1.MaxValue = 100F;
            this.temp1.MinValue = 0F;
            this.temp1.Name = "temp1";
            this.temp1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.temp1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.temp1.NeedleRadius = 80;
            this.temp1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.temp1.NeedleWidth = 2;
            this.temp1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.temp1.ScaleLinesInterInnerRadius = 73;
            this.temp1.ScaleLinesInterOuterRadius = 80;
            this.temp1.ScaleLinesInterWidth = 1;
            this.temp1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.temp1.ScaleLinesMajorInnerRadius = 70;
            this.temp1.ScaleLinesMajorOuterRadius = 80;
            this.temp1.ScaleLinesMajorStepValue = 10F;
            this.temp1.ScaleLinesMajorWidth = 2;
            this.temp1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.temp1.ScaleLinesMinorInnerRadius = 75;
            this.temp1.ScaleLinesMinorOuterRadius = 80;
            this.temp1.ScaleLinesMinorTicks = 9;
            this.temp1.ScaleLinesMinorWidth = 1;
            this.temp1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.temp1.ScaleNumbersFormat = null;
            this.temp1.ScaleNumbersRadius = 95;
            this.temp1.ScaleNumbersRotation = 0;
            this.temp1.ScaleNumbersStartScaleLine = 0;
            this.temp1.ScaleNumbersStepScaleLines = 1;
            this.temp1.Size = new System.Drawing.Size(248, 199);
            this.temp1.TabIndex = 8;
            this.temp1.Text = "RPM 1";
            this.temp1.Value = 0F;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(364, 476);
            this.textBox1.TabIndex = 10;
            this.textBox1.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 494);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.rpm2);
            this.Controls.Add(this.rpm1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Challenger Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.AGauge rpm1;
        private System.Windows.Forms.AGauge rpm2;
        private System.Windows.Forms.AGauge temp2;
        private System.Windows.Forms.AGauge temp1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

