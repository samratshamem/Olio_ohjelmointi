using System;

class Hissi
{
    private int _currentFloor; // Hissin nykyinen kerros

    // Julkinen ominaisuus nykyisen kerroksen lukemiseen
    public int CurrentFloor
    {
        get { return _currentFloor; }
        private set { _currentFloor = value; }
    }

    // Konstruktori asettaa hissin oletuskerrokseksi 1
    public Hissi()
    {
        _currentFloor = 1;
    }

    // Metodi hissin liikuttamiseen ylös
    public void MeneYlos()
    {
        if (_currentFloor < 6)
        {
            _currentFloor++;
            Console.WriteLine("Hissi on nyt kerroksessa: " + _currentFloor);
        }
        else
        {
            Console.WriteLine("Hissi on jo ylimmässä kerroksessa.");
        }
    }

    // Metodi hissin liikuttamiseen alas
    public void MeneAlas()
    {
        if (_currentFloor > 1)
        {
            _currentFloor--;
            Console.WriteLine("Hissi on nyt kerroksessa: " + _currentFloor);
        }
        else
        {
            Console.WriteLine("Hissi on jo alimmassa kerroksessa.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hissi hissi = new Hissi();

        // Pääohjelma, jossa käyttäjä voi liikuttaa hissiä
        while (true)
        {
            Console.WriteLine("Nykyinen kerros: " + hissi.CurrentFloor);
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("6. Mene ylös");
            Console.WriteLine("1. Mene alas");
            Console.WriteLine("0. Lopeta");

            int valinta;
            if (!int.TryParse(Console.ReadLine(), out valinta))
            {
                Console.WriteLine("Virheellinen valinta. Anna numero.");
                continue;
            }

            switch (valinta)
            {
                case 1:
                    hissi.MeneYlos();
                    break;
                case 2:
                    hissi.MeneAlas();
                    break;
                case 0:
                    Console.WriteLine("Ohjelma lopetetaan.");
                    return;
                default:
                    Console.WriteLine("Virheellinen valinta. Valitse 0, 1 tai 2.");
                    break;
            }
        }
    }
}