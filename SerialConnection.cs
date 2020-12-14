using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;

namespace TemperatureControllerProject
{
    public class SerialConnection
    {
        private SerialPort port = new SerialPort();

        public void Connect()
        {
            port.Open();
        }

        public async Task<string> ReadFromPort()
        {
            string data = "";
            await Task.Run(() =>
            {
                data = port.ReadExisting();

            });
            return data;
        }

        public void WriteToPort(string command)
        {
            port.Write(command);
            Thread.Sleep(100);

        }

        public void Disconnect()
        {
            port.Close();
        }
        public void SetSerialPort(string portName, int baudRate, Parity parity, int data, StopBits stop)
        {
            port.PortName = portName;
            port.BaudRate = baudRate;
            port.Parity = parity;
            port.StopBits = stop;
            port.DataBits = data;
        }

        public bool IsOpen()
        {
            if (port.IsOpen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
