using System.Windows;
using System.Windows.Controls;

namespace HarviaApp
{
    public partial class MainWindow : Window
    {
        private string currentInput = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumpadButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                currentInput += button.Content.ToString();
                InputBox.Text = currentInput;
            }
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(currentInput, out value))
            {
                if (TemperatureRadioButton.IsChecked == true)
                {
                    if (value >= 0 && value <= 120)
                    {
                        TemperatureValue.Text = value.ToString();
                    }
                }
                else if (HumidityRadioButton.IsChecked == true)
                {
                    if (value >= 0 && value <= 100)
                    {
                        HumidityValue.Text = value.ToString();
                    }
                }
            }
            currentInput = string.Empty; // Reset input after enter
            InputBox.Text = string.Empty; // Clear input box after enter
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                InputBox.Text = currentInput;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (TemperatureRadioButton.IsChecked == true)
            {
                EditModeLabel.Text = "Muokataan Lämpötila arvoja";
            }
            else if (HumidityRadioButton.IsChecked == true)
            {
                EditModeLabel.Text = "Muokataan Kosteus arvoja";
            }
        }
    }
}
