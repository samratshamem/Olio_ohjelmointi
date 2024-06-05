using System.Windows;

namespace ShoppingCartApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PaivitaOstoskori()
        {
            TextBlockOstoskorinTuotteet.Text = "";
            if (CheckBoxOmena.IsChecked == true)
            {
                TextBlockOstoskorinTuotteet.Text += "Omena\n";
            }
            if (CheckBoxBanaani.IsChecked == true)
            {
                TextBlockOstoskorinTuotteet.Text += "Banaani\n";
            }
            if (CheckBoxAppelsiini.IsChecked == true)
            {
                TextBlockOstoskorinTuotteet.Text += "Appelsiini\n";
            }
            if (CheckBoxRypäleet.IsChecked == true)
            {
                TextBlockOstoskorinTuotteet.Text += "Rypäleet\n";
            }

            if (TextBlockOstoskorinTuotteet.Text == "")
            {
                TextBlockOstoskorinTuotteet.Text = "Ei tuotteita ostoskorissa.";
            }
        }

        private void OstaNappi_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxOmena.IsChecked = false;
            CheckBoxBanaani.IsChecked = false;
            CheckBoxAppelsiini.IsChecked = false;
            CheckBoxRypäleet.IsChecked = false;
            TextBlockOstoskorinTuotteet.Text = "Ei tuotteita ostoskorissa.";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaivitaOstoskori();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PaivitaOstoskori();
        }
    }
}
