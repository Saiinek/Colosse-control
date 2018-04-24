using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Colosse_control.Pages;

namespace Colosse_control
{
    public class SerialPort
    {
        public static System.IO.Ports.SerialPort ComPort;

        public SerialPort(string PortName)
        {
            ComPort = new System.IO.Ports.SerialPort();
            ComPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
        }

        private void SerialPortOpened(string PortName)
        {
            try
            {
                ComPort.Close();
                ComPort.PortName = PortName;
                ComPort.BaudRate = 9600;
                ComPort.Parity = Parity.None;
                ComPort.DataBits = 8;
                ComPort.StopBits = StopBits.One;
                ComPort.Handshake = Handshake.None;

                //ComPort.ReadTimeout = 500;
                //ComPort.WriteTimeout = 500;

                ComPort.Open();
            }
            catch (Exception ex)
            {
                Notification.Exception(ex.ToString());
            }
        }

        private static void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string Incoming = ComPort.ReadLine();
            if (Incoming != String.Empty)
                Incoming = "i";
                //Data.MoniteurSerieText = Incoming;
        }
    }
}
