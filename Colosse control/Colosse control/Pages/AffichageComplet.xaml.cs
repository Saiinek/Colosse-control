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
    /// Logique d'interaction pour AffichageComplet.xaml
    /// </summary>
    public partial class AffichageComplet : Page
    {

        private int Row = 0;
        private Grid GContent = new Grid
        {
            Background = Brushes.LightGray
        };

        public AffichageComplet()
        {
            InitializeComponent();
            MoteurAffichage();
        }

        private void MoteurAffichage()
        {
            MoteurAf.Content = GContent;
            MoteurBuilder("Base", 0, 100, "");
        }
        private void MoteurBuilder(string Mname, int Maxvalue, int MinValue, string Cname)
        {
            Row++;
      
            
            Label LMname = new Label
            {
                Content = Mname
                
            };
            GContent.Children.Add(LMname);
        }
    }
}
