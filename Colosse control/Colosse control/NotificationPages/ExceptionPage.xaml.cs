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
    /// Logique d'interaction pour ExceptionPage.xaml
    /// </summary>
    public partial class ExceptionPage : Page
    {
        private readonly string TitleEx = " - Exception";
        public ExceptionPage(string message)
        {
            InitializeComponent();
            App.ActuelWindow.Title += TitleEx;
            ExceptionBox.Text = message;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.ActuelWindow.Title = App.ActuelWindow.Title.Remove(App.ActuelWindow.Title.Length - TitleEx.Length);
            Notification.Close();
        }
    }
}
