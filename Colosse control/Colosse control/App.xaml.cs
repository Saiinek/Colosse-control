using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Colosse_control
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow ActuelWindow;
        public App()
        {
            MainWindow win = new MainWindow();
            ActuelWindow = win;
            win.Show();
        }
    }
}
