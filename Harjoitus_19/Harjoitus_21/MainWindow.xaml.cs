using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TuoteApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = checkBox.Content.ToString(),
                    Tag = checkBox.Name
                };
                stackPanelOstoskori.Children.Add(textBlock);
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                var itemToRemove = stackPanelOstoskori.Children
                    .OfType<TextBlock>()
                    .FirstOrDefault(tb => tb.Tag.ToString() == checkBox.Name);
                if (itemToRemove != null)
                {
                    stackPanelOstoskori.Children.Remove(itemToRemove);
                }
            }
        }

        private void btnOsta_Click(object sender, RoutedEventArgs e)
        {
            // Tyhjennetään ostoskori
            stackPanelOstoskori.Children.Clear();

            // Asetetaan kaikki CheckBoxit unchecked-tilaan
            chkTuote1.IsChecked = false;
            chkTuote2.IsChecked = false;
            chkTuote3.IsChecked = false;
            chkTuote4.IsChecked = false;

            MessageBox.Show("Ostokset suoritettu!");
        }
    }
}
