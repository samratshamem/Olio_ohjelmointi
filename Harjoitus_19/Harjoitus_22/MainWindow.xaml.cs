using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WindowCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double width = double.Parse(TextBoxWidth.Text);
                double height = double.Parse(TextBoxHeight.Text);
                double frameWidth = double.Parse(TextBoxFrameWidth.Text);

                // Ikkunan ja lasin pinta-ala (mm^2 -> cm^2)
                double windowArea = (width * height) / 100;
                double glassArea = ((width - 2 * frameWidth) * (height - 2 * frameWidth)) / 100;

                // Karmin piiri (mm -> cm)
                double framePerimeter = 2 * (width + height) / 10;

                // Päivitä tekstikentät
                TextBlockWindowArea.Text = windowArea.ToString("F2") + " cm^2";
                TextBlockGlassArea.Text = glassArea.ToString("F2") + " cm^2";
                TextBlockFramePerimeter.Text = framePerimeter.ToString("F2") + " cm";

                // Piirrä ikkuna
                DrawWindow(width, height, frameWidth);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe syötteissä: " + ex.Message);
            }
        }

        private void DrawWindow(double width, double height, double frameWidth)
        {
            CanvasWindow.Children.Clear();

            // Muunna millimetrit pikseleiksi
            double scale = 0.1;

            double windowWidth = width * scale;
            double windowHeight = height * scale;
            double frameThickness = frameWidth * scale;

            // Piirrä ikkuna
            Rectangle windowRect = new Rectangle
            {
                Width = windowWidth,
                Height = windowHeight,
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Fill = Brushes.LightBlue
            };

            // Piirrä karmi
            Rectangle frameRect = new Rectangle
            {
                Width = windowWidth,
                Height = windowHeight,
                Stroke = Brushes.Brown,
                StrokeThickness = frameThickness,
                Fill = Brushes.Transparent
            };

            Canvas.SetLeft(windowRect, (CanvasWindow.ActualWidth - windowWidth) / 2);
            Canvas.SetTop(windowRect, (CanvasWindow.ActualHeight - windowHeight) / 2);

            Canvas.SetLeft(frameRect, (CanvasWindow.ActualWidth - windowWidth) / 2);
            Canvas.SetTop(frameRect, (CanvasWindow.ActualHeight - windowHeight) / 2);

            CanvasWindow.Children.Add(windowRect);
            CanvasWindow.Children.Add(frameRect);
        }
    }
}
