using System.Windows;
using System.Windows.Controls;

namespace HarviaControlPanel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TemperatureSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TemperatureLabel.Content = $"Lämpötila: {TemperatureSlider.Value}";
        }

        private void HumiditySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HumidityLabel.Content = $"Kosteus: {HumiditySlider.Value}";
        }
    }
}
