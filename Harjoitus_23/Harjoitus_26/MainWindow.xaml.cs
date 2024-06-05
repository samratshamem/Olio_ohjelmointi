using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace MuistiinpanoSovellus
{  
    public partial class MainWindow : Window
    {   // Luodaan muuttuja muistiinpanojen tallentamiseen
        private ObservableCollection<Muistiinpano> muistiinpanot;
        private string tiedostoPolku = "muistiinpanot.txt";

        public MainWindow()
        {   // ladataan muistiinpanot kokoelma ja ladataan tallennetut muistiinpanot
            InitializeComponent();
            muistiinpanot = new ObservableCollection<Muistiinpano>();
            LataaMuistiinpanot();
            DataContext = muistiinpanot;
        }

        private void LataaMuistiinpanot()
        {
            try
            {
                if (File.Exists(tiedostoPolku))
                {
                    using (StreamReader sr = new StreamReader(tiedostoPolku))
                    {
                        string rivi;
                        while ((rivi = sr.ReadLine()) != null)
                        {
                            muistiinpanot.Add(new Muistiinpano { Teksti = rivi });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe luettaessa muistiinpanoja: " + ex.Message);
            }
        }
        // tallentaa muistiinpanot tiedostoon
        private void TallennaMuistiinpanot()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tiedostoPolku))
                {
                    foreach (Muistiinpano muistiinpano in muistiinpanot)
                    {
                        sw.WriteLine(muistiinpano.Teksti);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe tallennettaessa muistiinpanoja: " + ex.Message);
            }
        }
        // Lisää uuden muistiinpanon ja tallentaa sen
        private void LisaaMuistiinpanoButton_Click(object sender, RoutedEventArgs e)
        {
            muistiinpanot.Add(new Muistiinpano { Teksti = MuistiinpanoTextBox.Text });
            MuistiinpanoTextBox.Clear();
            TallennaMuistiinpanot();
        }
        // Poistaa valitun muistiinpanon ja tallentaa muutokset
        private void PoistaMuistiinpanoButton_Click(object sender, RoutedEventArgs e)
        {
            if (MuistiinpanoListBox.SelectedItem != null)
            {
                muistiinpanot.Remove((Muistiinpano)MuistiinpanoListBox.SelectedItem);
                TallennaMuistiinpanot();
            }
        }
    }

    public class Muistiinpano
    {
        public string Teksti { get; set; }
    }
}
