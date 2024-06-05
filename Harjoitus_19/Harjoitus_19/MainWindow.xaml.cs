using System;
using System.Windows;

namespace HissiSovellus
{
    public partial class MainWindow : Window
    {
        Hissi hissi = new Hissi();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MeneKerrokseenButton_Click(object sender, RoutedEventArgs e)
        {
            int kerros;
            if (int.TryParse(KerrosTextBox.Text, out kerros))
            {
                if (hissi.MeneKerrokseen(kerros))
                {
                    MessageBox.Show($"Hissi saapuu kerrokseen {kerros}");
                }
                else
                {
                    MessageBox.Show($"Virheellinen kerros! Valitse kerros väliltä 1-6.");
                }
            }
            else
            {
                MessageBox.Show("Syötä kelvollinen kerrosnumero!");
            }
        }
    }

    public class Hissi
    {
        private int nykyinenKerros;

        public int NykyinenKerros
        {
            get { return nykyinenKerros; }
            private set { nykyinenKerros = value; }
        }

        public Hissi()
        {
            NykyinenKerros = 1; // Alusta hissi ensimmäiseen kerrokseen
        }

        public bool MeneKerrokseen(int kerros)
        {
            if (kerros >= 1 && kerros <= 6)
            {
                NykyinenKerros = kerros;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}