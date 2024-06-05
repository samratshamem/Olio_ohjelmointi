using System;
using System.Windows;

namespace WPF_Laskin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, RoutedEventArgs e)
        {
            double numero1, numero2;
            if (double.TryParse(Luku1.Text, out numero1) && double.TryParse(Luku2.Text, out numero2))
            {
                double tulos = 0;
                if (sender == SummaButton)
                {
                    tulos = numero1 + numero2;
                }
                else if (sender == ErotusButton)
                {
                    tulos = numero1 - numero2;
                }
                else if (sender == KertolaskuButton)
                {
                    tulos = numero1 * numero2;
                }
                else if (sender == JakolaskuButton && numero2 != 0)
                {
                    tulos = numero1 / numero2;
                }
                else
                {
                    MessageBox.Show("Virheellinen jakolasku! Nollalla ei voi jakaa.");
                    return;
                }

                Tulos.Text = tulos.ToString();
            }
            else
            {
                MessageBox.Show("Syötä luvut oikein!");
            }
        }
    }
}