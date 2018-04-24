using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Colosse_control.Pages
{
    /// <summary>
    /// Logique d'interaction pour ConnectionPage.xaml
    /// </summary>
    public partial class ConnectionPage : Page
    {
        private readonly string TitleCo = " - Connection";

        public ConnectionPage()
        {
            InitializeComponent();
            App.ActuelWindow.Title += TitleCo;
            string[] y = { };
            PortNameChanged(y);
            SerialPortEvent.PortsChanged += (sender1, changedArgs) => PortNameChanged(changedArgs.SerialPorts);
        }

        void PortNameChanged(string[] serialPorts)
        {
            PortBox.Items.Clear();

            if (serialPorts.Length.Equals(0))
            {
                PortBox.IsEnabled = false;
                Connection.IsEnabled = false;
                PortBox.Items.Add("-no COM");
                PortBox.SelectedIndex = 0;
            }
            else
            {
                PortBox.IsEnabled = true;
                Connection.IsEnabled = true;
                PortBox.SelectedIndex = 0;
            }
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            App.ActuelWindow.Title = App.ActuelWindow.Title.Remove(App.ActuelWindow.Title.Length - TitleCo.Length);
            Notification.Close();
        }

        private void Connection_Click(object sender, RoutedEventArgs e)
        {
            string PortName = PortBox.SelectedItem.ToString();
            if (PortName.Count() >= 4 &&
                PortName.Substring(0, 3).Equals("COM") &&
                int.TryParse(PortName.Substring(3), out int result) &&
                result >= 0)
            {
                SerialPort p = new SerialPort(PortName);
                Notification.Close();
            }
            else
            {
                Notification.Exception("invalid port name.");
            }
        }
    }
}
