using System;

public class Radio
{
    private bool _isOn;
    private int _volume;
    private double _frequency;

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
        if (volume >= 0 && volume <= 9)
        {
            _volume = volume;
            Console.WriteLine($"Äänenvoimakkuus asetettu {_volume}");
        }
        else
        {
            Console.WriteLine("Virheellinen äänenvoimakkuustaso. Valitse arvo väliltä 0-9.");
        }
    }

    public void SetFrequency(double frequency)
    {
        if (frequency >= 88.0 && frequency <= 107.9)
        {
            _frequency = frequency;
            Console.WriteLine($"Taajuus asetettu {_frequency} MHz");
        }
        else
        {
            Console.WriteLine("Virheellinen taajuus. Valitse arvo väliltä 88.0-107.9 MHz.");
        }
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Radio on {(IsOn ? "PÄÄLLÄ" : "POIS PÄÄLTÄ")}");
        Console.WriteLine($"Äänenvoimakkuus: {_volume}");
        Console.WriteLine($"Taajuus: {_frequency} MHz");
    }

    // Ominaisuudet
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