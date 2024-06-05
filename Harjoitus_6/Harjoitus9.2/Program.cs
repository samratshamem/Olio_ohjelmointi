using System;

public class Radio
{
     bool _isOn;
     int Musiucvolume { get { return Musiucvolume; } set
        {


            if (value >= 0 && value <= 9)
            {
                Musiucvolume = value;
                Console.WriteLine("Äänenvoimakkuus asetettu: " + Musiucvolume);
            }
            else
            {
                Console.WriteLine("Volume must be between 0 and 9.");
            }
        }
    }
    
    public double _frequency;
    int frequency { get { return frequency; } set
        {

            if (value >= 88.0 && value <= 107.9)
            {
                frequency = value;
                Console.WriteLine("Taajuus asetettu: " + frequency);
            }
            else
            {
                Console.WriteLine("Virheellinen taajuus. Valitse arvo väliltä 88.0-107.9 MHz.");
            }
        } }

    private int _volume;

    public Radio()
    {
        _isOn = false;
        _volume = 5;
        _frequency = 88.0;
    }

    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine("Radio on nyt PÄÄLLÄ.");
    }

    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine("Radio on nyt POIS PÄÄLTÄ.");
    }


    
     public void SetVolume(int volume)
     {

     }

     public void SetFrequency(double frequency)
     {

     }

    public void PrintStatus()
    {
        Console.WriteLine($"Radio on {(IsOn ? "PÄÄLLÄ" : "POIS PÄÄLTÄ")}");
        Console.WriteLine($"Äänenvoimakkuus: {_volume}");
        Console.WriteLine($"Taajuus: {_frequency} MHz");
    }

    public bool IsOn => _isOn;
}

class Program
{
    static void Main()
    {
        Radio omaRadio = new Radio();

        while (true)
        {
            Console.WriteLine("\n1. Kytke päälle\n2. Kytke pois päältä\n3. Aseta äänenvoimakkuus\n4. Aseta taajuus\n5. Tulosta tila\n6. Poistu");
            Console.Write("Syötä valintasi: ");
            int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    omaRadio.TurnOn();
                    break;
                case 2:
                    omaRadio.TurnOff();
                    break;
                case 3:
                    Console.Write("Syötä äänenvoimakkuus (0-9): ");
                    int voimakkuus = int.Parse(Console.ReadLine());
                    omaRadio.SetVolume(voimakkuus);
                    break;
                case 4:
                    Console.Write("Syötä taajuus (88.0-107.9): ");
                    double taajuus = double.Parse(Console.ReadLine());
                    omaRadio.SetFrequency(taajuus);
                    break;
                case 5:
                    omaRadio.PrintStatus();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                    break;
            }
        }
    }
}