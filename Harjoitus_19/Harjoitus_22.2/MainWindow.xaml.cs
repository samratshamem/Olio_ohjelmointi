using System;
using System.Windows;

namespace WpfWindowArea
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double width = Convert.ToDouble(txtWidth.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double frameWidth = Convert.ToDouble(txtFrameWidth.Text);

            double windowArea = width * height;
            double glassArea = (width - 2 * frameWidth) * (height - 2 * frameWidth);
            double framePerimeter = 2 * (width + height);

            txtWindowArea.Text = (windowArea / 100).ToString();
            txtGlassArea.Text = (glassArea / 100).ToString();
            txtFramePerimeter.Text = (framePerimeter / 10).ToString();
        }
    }
}
