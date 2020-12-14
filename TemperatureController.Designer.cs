
namespace TemperatureControllerProject
{
    partial class TemperatureController
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
            this.Params = new System.Windows.Forms.GroupBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.StopBits = new System.Windows.Forms.ComboBox();
            this.DataBits = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.ComPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Limits = new System.Windows.Forms.GroupBox();
            this.SetThreshold = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.High = new System.Windows.Forms.TextBox();
            this.Low = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Auto = new System.Windows.Forms.Button();
            this.Manual = new System.Windows.Forms.Button();
            this.Params.SuspendLayout();
            this.Limits.SuspendLayout();
            this.SuspendLayout();
            // 
            // Params
            // 
            this.Params.Controls.Add(this.Connect);
            this.Params.Controls.Add(this.Parity);
            this.Params.Controls.Add(this.StopBits);
            this.Params.Controls.Add(this.DataBits);
            this.Params.Controls.Add(this.BaudRate);
            this.Params.Controls.Add(this.ComPort);
            this.Params.Controls.Add(this.label5);
            this.Params.Controls.Add(this.label4);
            this.Params.Controls.Add(this.label3);
            this.Params.Controls.Add(this.label2);
            this.Params.Controls.Add(this.label1);
            this.Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Params.Location = new System.Drawing.Point(27, 136);
            this.Params.Name = "Params";
            this.Params.Size = new System.Drawing.Size(366, 314);
            this.Params.TabIndex = 0;
            this.Params.TabStop = false;
            this.Params.Text = "Connection Prameters";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.SteelBlue;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Connect.Location = new System.Drawing.Point(151, 265);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(93, 34);
            this.Connect.TabIndex = 10;
            this.Connect.Text = "CONNECT";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Parity
            // 
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.Parity.Location = new System.Drawing.Point(151, 207);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(121, 28);
            this.Parity.TabIndex = 9;
            // 
            // StopBits
            // 
            this.StopBits.FormattingEnabled = true;
            this.StopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.StopBits.Location = new System.Drawing.Point(151, 166);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(121, 28);
            this.StopBits.TabIndex = 8;
            // 
            // DataBits
            // 
            this.DataBits.FormattingEnabled = true;
            this.DataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.DataBits.Location = new System.Drawing.Point(151, 125);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(121, 28);
            this.DataBits.TabIndex = 7;
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(151, 85);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 28);
            this.BaudRate.TabIndex = 6;
            // 
            // ComPort
            // 
            this.ComPort.FormattingEnabled = true;
            this.ComPort.Location = new System.Drawing.Point(151, 42);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(121, 28);
            this.ComPort.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(70, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(932, 68);
            this.label6.TabIndex = 1;
            this.label6.Text = "TEMPERATURE CONTROLLER";
            // 
            // Limits
            // 
            this.Limits.Controls.Add(this.SetThreshold);
            this.Limits.Controls.Add(this.textBox2);
            this.Limits.Controls.Add(this.High);
            this.Limits.Controls.Add(this.Low);
            this.Limits.Controls.Add(this.label7);
            this.Limits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limits.Location = new System.Drawing.Point(502, 136);
            this.Limits.Name = "Limits";
            this.Limits.Size = new System.Drawing.Size(279, 194);
            this.Limits.TabIndex = 2;
            this.Limits.TabStop = false;
            this.Limits.Text = "Threshold Settings";
            // 
            // SetThreshold
            // 
            this.SetThreshold.BackColor = System.Drawing.Color.SteelBlue;
            this.SetThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetThreshold.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetThreshold.Location = new System.Drawing.Point(88, 140);
            this.SetThreshold.Name = "SetThreshold";
            this.SetThreshold.Size = new System.Drawing.Size(75, 34);
            this.SetThreshold.TabIndex = 4;
            this.SetThreshold.Text = "SET";
            this.SetThreshold.UseVisualStyleBackColor = false;
            this.SetThreshold.Click += new System.EventHandler(this.SetThreshold_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(189, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 30);
            this.textBox2.TabIndex = 3;
            // 
            // High
            // 
            this.High.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.High.Location = new System.Drawing.Point(189, 35);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(70, 30);
            this.High.TabIndex = 2;
            // 
            // Low
            // 
            this.Low.AutoSize = true;
            this.Low.Location = new System.Drawing.Point(34, 87);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(149, 20);
            this.Low.TabIndex = 1;
            this.Low.Text = "Lower Limit(in C) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Upper Limit(in C) :";
            // 
            // Auto
            // 
            this.Auto.BackColor = System.Drawing.Color.SteelBlue;
            this.Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Auto.Location = new System.Drawing.Point(502, 401);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(249, 49);
            this.Auto.TabIndex = 3;
            this.Auto.Text = "AUTO MODE";
            this.Auto.UseVisualStyleBackColor = false;
            this.Auto.Click += new System.EventHandler(this.Auto_Click);
            // 
            // Manual
            // 
            this.Manual.BackColor = System.Drawing.Color.SteelBlue;
            this.Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Manual.Location = new System.Drawing.Point(502, 468);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(249, 49);
            this.Manual.TabIndex = 4;
            this.Manual.Text = "MANUAL MODE";
            this.Manual.UseVisualStyleBackColor = false;
            this.Manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // TemperatureController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(872, 588);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.Auto);
            this.Controls.Add(this.Limits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Params);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TemperatureController";
            this.Text = "TemperatureController";
            this.Load += new System.EventHandler(this.TemperatureController_Load);
            this.Params.ResumeLayout(false);
            this.Params.PerformLayout();
            this.Limits.ResumeLayout(false);
            this.Limits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Params;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox StopBits;
        private System.Windows.Forms.ComboBox DataBits;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox ComPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Limits;
        private System.Windows.Forms.Button SetThreshold;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox High;
        private System.Windows.Forms.Label Low;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Auto;
        private System.Windows.Forms.Button Manual;
    }
}

