using System;
using System.Windows;

namespace WpfElevator
{
    public partial class MainWindow : Window
    {
        private Elevator elevator;

        public MainWindow()
        {
            InitializeComponent();
            elevator = new Elevator();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int floor;
            if (int.TryParse(FloorInput.Text, out floor))
            {
                if (floor >= 1 && floor <= 6)
                {
                    elevator.Floor = floor;
                    FloorDisplay.Text = $"Hissi on kerroksessa {elevator.Floor}";
                }
                else
                {
                    FloorDisplay.Text = "Virheellinen kerros. Valitse kerros väliltä 1-6.";
                }
            }
            else
            {
                FloorDisplay.Text = "Syötä numero.";
            }
        }
    }

    public class Elevator
    {
        private int floor;

        public int Floor
        {
            get { return floor; }
            set
            {
                if (value >= 1 && value <= 6)
                {
                    floor = value;
                }
                else
                {
                    throw new ArgumentException("Kerros tulee olla väliltä 1-6.");
                }
            }
        }
    }
}