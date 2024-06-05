using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LottoApp
{
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        private List<int[]> _arvotutRivit = new List<int[]>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TulostaButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(RivitTextBox.Text, out int rivienMaara) && PeliComboBox.SelectedItem != null)
            {
                _arvotutRivit.Clear();
                string peli = ((ComboBoxItem)PeliComboBox.SelectedItem).Content.ToString();
                for (int i = 0; i < rivienMaara; i++)
                {
                    int[] rivi = ArvoRivi(peli);
                    _arvotutRivit.Add(rivi);
                    ArvotutRivitTextBlock.Text += string.Join(", ", rivi) + "\n";
                }
            }
        }

        private void TyhjennaButton_Click(object sender, RoutedEventArgs e)
        {
            _arvotutRivit.Clear();
            ArvotutRivitTextBlock.Text = "";
            TuloksetTextBlock.Text = "";
        }

        private void ViikonArvontaButton_Click(object sender, RoutedEventArgs e)
        {
            if (PeliComboBox.SelectedItem != null)
            {
                string peli = ((ComboBoxItem)PeliComboBox.SelectedItem).Content.ToString();
                int[] viikonRivi = ArvoRivi(peli);
                ArvotutRivitTextBlock.Text += "Viikon arvonta: " + string.Join(", ", viikonRivi) + "\n";
            }
        }

        private void TarkastaButton_Click(object sender, RoutedEventArgs e)
        {
            if (PeliComboBox.SelectedItem != null)
            {
                string peli = ((ComboBoxItem)PeliComboBox.SelectedItem).Content.ToString();
                int[] viikonRivi = ArvoRivi(peli);
                int voittoRiveja = 0;
                int parasOsumat = 0;

                foreach (var rivi in _arvotutRivit)
                {
                    int osumat = rivi.Intersect(viikonRivi).Count();
                    if (osumat >= 3) voittoRiveja++;
                    if (osumat > parasOsumat) parasOsumat = osumat;
                }

                TuloksetTextBlock.Text = $"Voitto rivejä: {voittoRiveja}, Paras osuma: {parasOsumat}";
            }
        }

        private int[] ArvoRivi(string peli)
        {
            int[] rivi;
            switch (peli)
            {
                case "Lotto":
                    rivi = ArvoNumerot(7, 1, 40);
                    break;
                case "Viking Lotto":
                    rivi = ArvoNumerot(6, 1, 48);
                    break;
                case "Eurojackpot":
                    rivi = ArvoNumerot(5, 1, 50).Concat(ArvoNumerot(2, 1, 10)).ToArray();
                    break;
                default:
                    rivi = new int[0];
                    break;
            }
            return rivi;
        }

        private int[] ArvoNumerot(int lukumaara, int min, int max)
        {
            HashSet<int> numerot = new HashSet<int>();
            while (numerot.Count < lukumaara)
            {
                numerot.Add(_random.Next(min, max + 1));
            }
            return numerot.OrderBy(n => n).ToArray();
        }
    }
}
