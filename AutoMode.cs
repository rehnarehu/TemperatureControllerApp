using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Threading;

namespace TemperatureControllerProject
{
    public partial class AutoMode : Form
    {
        bool ledOff = true;
        static double Low = 20, High = 30;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        SerialConnection myPort = new SerialConnection();
        public AutoMode(SerialConnection serialPort)
        {
            InitializeComponent();
            myPort = serialPort;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            timer.Stop();
            double rate = double.Parse(Rate.Text) * 1000;
            timer.Interval = Convert.ToInt32(rate);
            timer.Start();
        }

        private void Manual_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManualMode manual = new ManualMode(myPort);
            manual.Show();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            TemperatureController temp = new TemperatureController();
            temp.VisibleForm();
        }

        private void AutoMode_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Temperature";
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            Rate.Text = "1";
            timer.Tick += new EventHandler(timer_Tick);
            double rate = double.Parse(Rate.Text) * 1000;
            timer.Interval = Convert.ToInt32(rate); // in miliseconds
            //myPort.ReadExisting();
            myPort.WriteToPort("GET TEMP\r");
            //Thread.Sleep(100);
            ReadAndWrite();
            timer.Start();
        }
        private static bool CheckForAlarm(double value, double low, double high)
        {
            bool alarm = false;
            if (value < low || value > high)
            {
                alarm = true;
            }
            return alarm;
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            ReadAndWrite();

        }
        public async void ReadAndWrite()
        {

            int series = 0;
            double temperature;
            DateTime now = DateTime.Now; 
            string data = await myPort.ReadFromPort();
            double.TryParse(data, out temperature);
            Console.WriteLine(data);
            if (CheckForAlarm(temperature, Low, High))
            {
                series = 1;
                if (this.ledOff)
                {
                    myPort.WriteToPort("LED1 ON\r");
                    await myPort.ReadFromPort();
                    this.ledOff = false;
                }
            }
            else
            {
                if (!this.ledOff)
                {
                    myPort.WriteToPort("LED1 OFF\r");
                    await myPort.ReadFromPort();
                    this.ledOff = true;
                }
            }
            WriteText(data);
            Command();
            DrawGraph(temperature, now, series);

        }
        public void Command()
        {
            myPort.WriteToPort("GET TEMP\r");

        }
        public void WriteText(string data)
        {
            Output.AppendText(data + "\n");
        }
        public void DrawGraph(double temp, DateTime time, int series)
        {
            DataPoint point = new DataPoint(chart1.Series[0]);

            if (series == 0)
            {

                chart1.Series[0].Points.AddXY(time, temp);
                point = chart1.Series[0].Points.Last();
                point.MarkerColor = Color.Green;
            }
            else
            {
                InsertAlarm(temp, time);
                chart1.Series[0].Points.AddXY(time, temp);
                point = chart1.Series[0].Points.Last();
                point.MarkerColor = Color.Red;
            }

        }
        int alarm = 0;
        private void InsertAlarm(double temp, DateTime time)
        {
            Alarms.Rows.Add(alarm++, time, temp);
        }
        public static void SetLimits(double high, double low) 
        {
            High = high;
            Low = low;
        }
        public void VisibleForm()
        {
            this.Show();
        }
    }
}
