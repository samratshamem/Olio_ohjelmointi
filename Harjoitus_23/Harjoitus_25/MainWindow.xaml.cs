using System.Collections.Generic;
using System.Windows;
using Newtonsoft.Json;

namespace JoukkueApp
{
    public partial class MainWindow : Window
    {
        private List<Joukkue> joukkueet = new List<Joukkue>();
        private JoukkueService joukkueService = new JoukkueService();

        public MainWindow()
        {
            InitializeComponent();
            JoukkueDataGrid.SelectionChanged += JoukkueDataGrid_SelectionChanged;
        }

        private void LataaJoukkueet_Click(object sender, RoutedEventArgs e)
        {
            joukkueet = joukkueService.LataaJoukkueet();
            JoukkueDataGrid.ItemsSource = joukkueet;
        }

        private void TallennaJoukkueet_Click(object sender, RoutedEventArgs e)
        {
            joukkueService.TallennaJoukkueet(joukkueet);
        }

        private void JoukkueDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (JoukkueDataGrid.SelectedItem is Joukkue selectedJoukkue)
            {
                PelaajaDataGrid.ItemsSource = selectedJoukkue.Pelaajat;
            }
        }
    }
}
