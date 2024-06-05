using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;

namespace OpiskelijaApp
{
    [Serializable]
    public class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int OpiskelijaID { get; set; }
        public string Sahkoposti { get; set; }
        public string Puhelinnumero { get; set; }
    }

    public partial class MainWindow : Window
    {
        private List<Opiskelija> opiskelijat = new List<Opiskelija>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int opiskelijaID;
            if (int.TryParse(txtOpiskelijaID.Text, out opiskelijaID))
            {
                if (opiskelijat.Any(o => o.OpiskelijaID == opiskelijaID || o.Sahkoposti == txtSahkoposti.Text))
                {
                    MessageBox.Show("Opiskelija ID tai sähköposti on jo käytössä.");
                }
                else
                {
                    Opiskelija uusiOpiskelija = new Opiskelija
                    {
                        Etunimi = txtEtunimi.Text,
                        Sukunimi = txtSukunimi.Text,
                        OpiskelijaID = opiskelijaID,
                        Sahkoposti = txtSahkoposti.Text,
                        Puhelinnumero = txtPuhelinnumero.Text
                    };

                    opiskelijat.Add(uusiOpiskelija);
                    PäivitäNäyttö();
                    TyhjennäKentät();
                }
            }
            else
            {
                MessageBox.Show("Virheellinen Opiskelija ID.");
            }
        }

        private void PäivitäNäyttö()
        {
            stackPanelOpiskelijat.Children.Clear();
            foreach (var opiskelija in opiskelijat)
            {
                TextBlock txtOpiskelija = new TextBlock
                {
                    Text = $"{opiskelija.OpiskelijaID}: {opiskelija.Etunimi} {opiskelija.Sukunimi}, {opiskelija.Sahkoposti}, {opiskelija.Puhelinnumero}"
                };
                stackPanelOpiskelijat.Children.Add(txtOpiskelija);
            }
        }

        private void TyhjennäKentät()
        {
            txtEtunimi.Clear();
            txtSukunimi.Clear();
            txtOpiskelijaID.Clear();
            txtSahkoposti.Clear();
            txtPuhelinnumero.Clear();
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveToFile("opiskelijat.dat");
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            LoadFromFile("opiskelijat.dat");
            PäivitäNäyttö();
        }

        private void SaveToFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, opiskelijat);
                    MessageBox.Show("Opiskelijat tallennettu onnistuneesti.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tallennuksessa: {ex.Message}");
            }
        }

        private void LoadFromFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    opiskelijat = (List<Opiskelija>)formatter.Deserialize(fs);
                    MessageBox.Show("Opiskelijat ladattu onnistuneesti.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe latauksessa: {ex.Message}");
            }
        }
    }
}
