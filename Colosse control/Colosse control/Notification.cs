using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using Colosse_control;
using Colosse_control.Pages;

namespace Colosse_control
{
    class Notification
    {
        private static int OpenedPage = 0;

        public static void Exception(string message)
        {
            App.ActuelWindow.NotificationContent.Visibility = System.Windows.Visibility.Visible;
            App.ActuelWindow.NotificationContent.Content = new ExceptionPage(message);
            OpenedPage++;
        }

        public static void Connection()
        {
            App.ActuelWindow.NotificationContent.Visibility = System.Windows.Visibility.Visible;
            NotificationBuilder();
            //App.ActuelWindow.NotificationContent.Content = new ConnectionPage();
            //OpenedPage++;
        }


        private static void NotificationBuilder()
        {
            Grid Background = new Grid
            {
                Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4C000000"))
            };
            App.ActuelWindow.NotificationContent.Content = Background;
        }

        public static void Close()
        {
            
            if (OpenedPage > 1)
            {
                App.ActuelWindow.NotificationContent.NavigationService.GoBack();
            }
            else
            {
                App.ActuelWindow.NotificationContent.Content = null;
            }
            OpenedPage--;
            App.ActuelWindow.NotificationContent.NavigationService.RemoveBackEntry();
        }
    }
}
