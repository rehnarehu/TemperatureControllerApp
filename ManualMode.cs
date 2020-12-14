using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace TemperatureControllerProject
{
    public partial class ManualMode : Form
    {
        SerialConnection serialPort;
        public ManualMode(SerialConnection serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
        }

        private void LedRedOn_Click(object sender, EventArgs e)
        {
            serialPort.WriteToPort("LED1 ON\r");
            //Thread.Sleep(100);
            Print();
        }

        private void LedRedOff_Click(object sender, EventArgs e)
        {
            serialPort.WriteToPort("LED1 OFF\r");
            //Thread.Sleep(100);
            Print();
        }

        private void LedGreenOn_Click(object sender, EventArgs e)
        {
            serialPort.WriteToPort("LED2 ON\r");
            //Thread.Sleep(100);
            Print();
        }

        private void LedGreenOff_Click(object sender, EventArgs e)
        {
            serialPort.WriteToPort("LED2 OFF\r");
            Thread.Sleep(100);
            Print();
        }

        private void BuzzOn_Click(object sender, EventArgs e)
        {
            serialPort.WriteToPort("BUZZER ON\r");
            //Thread.Sleep(100);
            Print();
        }

        private void BuzzOff_Click(object sender, EventArgs e)
        {
            serialPort.WriteToPort("BUZZER OFF\r");
            //Thread.Sleep(100);
            Print();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            this.Close();
            TemperatureController temp = new TemperatureController();
            temp.VisibleForm();
        }

        private void Auto_Click(object sender, EventArgs e)
        {
            this.Close();
            AutoMode auto = new AutoMode(serialPort);
            auto.VisibleForm();
        }
        private async void Print()
        {
            string buffer = await serialPort.ReadFromPort();
            string msg = buffer;
            Output.AppendText(msg + "\n");
        }
    }
}
