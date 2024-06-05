using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace DistanceConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKmToMiles_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKilometers.Text))
            {
                double kilometers;
                if (double.TryParse(txtKilometers.Text, out kilometers))
                {
                    double miles = kilometers * 0.621371;
                    txtMiles.Text = miles.ToString("0.##");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for kilometers.");
                }
            }
            else if (!string.IsNullOrEmpty(txtMiles.Text))
            {
                double miles;
                if (double.TryParse(txtMiles.Text, out miles))
                {
                    double kilometers = miles * 1.60934;
                    txtKilometers.Text = kilometers.ToString("0.##");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for miles.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a value to convert.");
            }
        }
    }
}