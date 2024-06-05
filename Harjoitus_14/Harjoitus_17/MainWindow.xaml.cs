using System.Windows;

namespace TalonHallintaSovellus
{
    public partial class MainWindow : Window
    {
        // Muuttujat talon tilojen tallentamiseen
        float lämpötila;
        bool keittiöValot;
        bool olohuoneenValot;
        bool oviLukossa;

        public MainWindow()
        {
            InitializeComponent();

            // Alusta muuttujat
            lämpötila = 20.0f; // Alustetaan lämpötila esimerkkilukemalla
            keittiöValot = false; // Alustetaan valot pois päältä
            olohuoneenValot = false; // Alustetaan valot pois päältä
            oviLukossa = false; // Alustetaan ovi auki
        }

        // Metodi lämpötilan muuttamiseen
        private void LämpötilaSäädin_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lämpötila = (float)LämpötilaSäädin.Value;
        }

        // Metodi keittiön valojen tilan muuttamiseen
        private void KeittiöValotNappi_Click(object sender, RoutedEventArgs e)
        {
            keittiöValot = !keittiöValot; // Käänteinen arvo (päälle/pois)
            // Voit täällä lisätä koodin valojen päälle/pois kytkemiseen talossa
        }

        // Metodi olohuoneen valojen tilan muuttamiseen
        private void OlohuoneenValotNappi_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenValot = !olohuoneenValot; // Käänteinen arvo (päälle/pois)
            // Voit täällä lisätä koodin valojen päälle/pois kytkemiseen talossa
        }

        // Metodi oven tilan muuttamiseen
        private void OviNappi_Click(object sender, RoutedEventArgs e)
        {
            oviLukossa = !oviLukossa; // Käänteinen arvo (lukossa/auki)
            // Voit täällä lisätä koodin oven lukituksen tilan muuttamiseen talossa
        }
    }
}