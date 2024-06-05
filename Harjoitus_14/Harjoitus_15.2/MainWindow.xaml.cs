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

namespace Harjoitus_15._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int HenkilöAuto = 0;
        private int KuormaAuto = 0;

        public MainWindow()
        {
            InitializeComponent();
            
            tbHenkilöAuto.Text = HenkilöAuto.ToString();
            tbKuormaAuto.Text = KuormaAuto.ToString();
        }

        private void Henkilöauto_Click(object sender, RoutedEventArgs e)
        {
            HenkilöAuto++;
            tbHenkilöAuto.Text = HenkilöAuto.ToString();
        }

        private void Kuorma_auto_Click(object sender, RoutedEventArgs e)
        {
            KuormaAuto++;
            tbKuormaAuto.Text = KuormaAuto.ToString();
        }
    }
}
