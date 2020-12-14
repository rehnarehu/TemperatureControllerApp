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
using System.IO;
using System.Xml.Serialization;
[assembly: CLSCompliant(true)]
namespace TemperatureControllerProject
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TemperatureController : Form
    {
        string xmlPath = "Serial.xml";
        SerialConnection serial = new SerialConnection();
        
        public TemperatureController()
        {
            InitializeComponent();
        }
        private void UpdatePorts()
        {
            //if (SerialPort.GetPortNames().Count() < 1)
            //{
                //throw new 
            //}
            foreach (string port in SerialPort.GetPortNames()) 
            {
                ComPort.Items.Add(port);
            }
        }

        private void Connecting()
        {
            
            bool error = false;
            if (ComPort.SelectedIndex != -1 && BaudRate.SelectedIndex != -1 && Parity.SelectedIndex != -1 && StopBits.SelectedIndex != -1 && DataBits.SelectedIndex != -1)
            {
                serial.SetSerialPort(ComPort.Text, int.Parse(BaudRate.Text), (Parity)Enum.Parse(typeof(Parity), Parity.Text), int.Parse(DataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), StopBits.Text));
                try
                {
                    serial.Connect();
                    Limits.Enabled = true;
                    Manual.Enabled = true;
                    Auto.Enabled = true;
                    MessageBox.Show("Connected");
                }
                catch (FormatException) { MessageBox.Show("Not in correct format"); }
                catch (ArgumentNullException) { error = true; }
                catch (IOException) { error = true; }
                //catch (Exception) { error = true; }
                if (error == true)
                {
                    MessageBox.Show(this, "Could not open the COM port.Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            else
            {
                MySerialPort config;
                XmlSerializer xmlserialize = new XmlSerializer(typeof(MySerialPort));
                using (TextReader sr = new StreamReader(xmlPath))
                {
                    config = (MySerialPort)xmlserialize.Deserialize(sr);

                }

                serial.SetSerialPort(config.PortName, config.BaudRate, config.Parity, config.DataBits, (StopBits)Enum.Parse(typeof(StopBits), config.StopBits));
                try
                {
                    serial.Connect();
                    Limits.Enabled = true;
                    Manual.Enabled = true;
                    Auto.Enabled = true;

                    MessageBox.Show("Connecting using Default Parameters");

                }
                catch (FormatException) { MessageBox.Show("Not in correct format"); }
                catch (ArgumentNullException) { error = true; }
                catch (IOException) { error = true; }
                //catch (Exception) { error = true; }
                if (error == true)
                {
                    MessageBox.Show(this, "Could not open the COM port.Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            if (serial.IsOpen())
            {
                Connect.Text = "Disonnect";
                Params.Enabled = false;
                Limits.Enabled = true;


            }
        }
        private void Disconnect()
        {
            serial.Disconnect();
            Connect.Text = "Connect";
            Params.Enabled = true;
            Limits.Enabled = false;
            Manual.Enabled = false;
            Auto.Enabled = false;

        }


        private void Connect_Click(object sender, EventArgs e)
        {

            if (serial.IsOpen())
            {
                Disconnect();
            }
            else
            {
                Connecting();
            }
        }

        private void Manual_Click(object sender, EventArgs e)
        {
            ManualMode f = new ManualMode(serial);
            this.Hide();
            f.Show();
        }


        private void Auto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoMode auto = new AutoMode(serial);
            auto.Show();
        }

        private void SetThreshold_Click(object sender, EventArgs e)
        {
            try
            {
                var high = double.Parse(High.Text);
                var low = double.Parse(Low.Text);
                AutoMode.SetLimits(high, low);
                serial.WriteToPort("SET LIMIT " + low + " " + high + '\r');
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the temperature in correct format");
            }
        }

        private void TemperatureController_Load(object sender, EventArgs e)
        {
            UpdatePorts();
            Limits.Enabled = false;
            Manual.Enabled = false;
            Auto.Enabled = false;
        }
        public void VisibleForm()
        {
            this.Visible=true;
        }
    }
}
