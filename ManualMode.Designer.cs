
namespace TemperatureControllerProject
{
    partial class ManualMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LedRedOn = new System.Windows.Forms.Button();
            this.LedGreenOn = new System.Windows.Forms.Button();
            this.BuzzOn = new System.Windows.Forms.Button();
            this.LedRedOff = new System.Windows.Forms.Button();
            this.LedGreenOff = new System.Windows.Forms.Button();
            this.BuzzOff = new System.Windows.Forms.Button();
            this.Auto = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANUAL MODE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuzzOff);
            this.groupBox1.Controls.Add(this.LedGreenOff);
            this.groupBox1.Controls.Add(this.LedRedOff);
            this.groupBox1.Controls.Add(this.BuzzOn);
            this.groupBox1.Controls.Add(this.LedGreenOn);
            this.groupBox1.Controls.Add(this.LedRedOn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "LED RED :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "LED GREEN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(18, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "BUZZER";
            // 
            // LedRedOn
            // 
            this.LedRedOn.BackColor = System.Drawing.Color.SteelBlue;
            this.LedRedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedRedOn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LedRedOn.Location = new System.Drawing.Point(164, 39);
            this.LedRedOn.Name = "LedRedOn";
            this.LedRedOn.Size = new System.Drawing.Size(80, 45);
            this.LedRedOn.TabIndex = 3;
            this.LedRedOn.Text = "ON";
            this.LedRedOn.UseVisualStyleBackColor = false;
            this.LedRedOn.Click += new System.EventHandler(this.LedRedOn_Click);
            // 
            // LedGreenOn
            // 
            this.LedGreenOn.BackColor = System.Drawing.Color.SteelBlue;
            this.LedGreenOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedGreenOn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LedGreenOn.Location = new System.Drawing.Point(164, 106);
            this.LedGreenOn.Name = "LedGreenOn";
            this.LedGreenOn.Size = new System.Drawing.Size(80, 45);
            this.LedGreenOn.TabIndex = 4;
            this.LedGreenOn.Text = "ON";
            this.LedGreenOn.UseVisualStyleBackColor = false;
            this.LedGreenOn.Click += new System.EventHandler(this.LedGreenOn_Click);
            // 
            // BuzzOn
            // 
            this.BuzzOn.BackColor = System.Drawing.Color.SteelBlue;
            this.BuzzOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuzzOn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuzzOn.Location = new System.Drawing.Point(164, 175);
            this.BuzzOn.Name = "BuzzOn";
            this.BuzzOn.Size = new System.Drawing.Size(80, 45);
            this.BuzzOn.TabIndex = 5;
            this.BuzzOn.Text = "ON";
            this.BuzzOn.UseVisualStyleBackColor = false;
            this.BuzzOn.Click += new System.EventHandler(this.BuzzOn_Click);
            // 
            // LedRedOff
            // 
            this.LedRedOff.BackColor = System.Drawing.Color.SteelBlue;
            this.LedRedOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedRedOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LedRedOff.Location = new System.Drawing.Point(270, 39);
            this.LedRedOff.Name = "LedRedOff";
            this.LedRedOff.Size = new System.Drawing.Size(80, 45);
            this.LedRedOff.TabIndex = 6;
            this.LedRedOff.Text = "OFF";
            this.LedRedOff.UseVisualStyleBackColor = false;
            this.LedRedOff.Click += new System.EventHandler(this.LedRedOff_Click);
            // 
            // LedGreenOff
            // 
            this.LedGreenOff.BackColor = System.Drawing.Color.SteelBlue;
            this.LedGreenOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedGreenOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LedGreenOff.Location = new System.Drawing.Point(270, 106);
            this.LedGreenOff.Name = "LedGreenOff";
            this.LedGreenOff.Size = new System.Drawing.Size(80, 45);
            this.LedGreenOff.TabIndex = 7;
            this.LedGreenOff.Text = "OFF";
            this.LedGreenOff.UseVisualStyleBackColor = false;
            this.LedGreenOff.Click += new System.EventHandler(this.LedGreenOff_Click);
            // 
            // BuzzOff
            // 
            this.BuzzOff.BackColor = System.Drawing.Color.SteelBlue;
            this.BuzzOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuzzOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuzzOff.Location = new System.Drawing.Point(270, 175);
            this.BuzzOff.Name = "BuzzOff";
            this.BuzzOff.Size = new System.Drawing.Size(80, 45);
            this.BuzzOff.TabIndex = 8;
            this.BuzzOff.Text = "OFF";
            this.BuzzOff.UseVisualStyleBackColor = false;
            this.BuzzOff.Click += new System.EventHandler(this.BuzzOff_Click);
            // 
            // Auto
            // 
            this.Auto.BackColor = System.Drawing.Color.SteelBlue;
            this.Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Auto.Location = new System.Drawing.Point(324, 362);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(162, 58);
            this.Auto.TabIndex = 2;
            this.Auto.Text = "AUTO MODE";
            this.Auto.UseVisualStyleBackColor = false;
            this.Auto.Click += new System.EventHandler(this.Auto_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.SteelBlue;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Connect.Location = new System.Drawing.Point(137, 362);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(155, 58);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "CONNECTION SCREEN";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(6, 19);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(225, 220);
            this.Output.TabIndex = 4;
            this.Output.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Output);
            this.groupBox2.Location = new System.Drawing.Point(479, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 252);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // ManualMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Auto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "ManualMode";
            this.Text = "ManualMode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuzzOff;
        private System.Windows.Forms.Button LedGreenOff;
        private System.Windows.Forms.Button LedRedOff;
        private System.Windows.Forms.Button BuzzOn;
        private System.Windows.Forms.Button LedGreenOn;
        private System.Windows.Forms.Button LedRedOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Auto;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}