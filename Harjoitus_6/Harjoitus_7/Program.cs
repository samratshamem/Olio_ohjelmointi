using System;

public class Hissi
{
    private int _kerros;

    public int Kerros
    {
        get { return _kerros; }
        set
        {
            if (value >= 1 && value <= 6)
            {
                _kerros = value;
            }
            else
            {
                Console.WriteLine("Virheellinen kerros! Kerroksen tulee olla välillä 1 - 6.");
            }
        }
    }

    public void MeneKerrokseen(int haluttuKerros)
    {
        Kerros = haluttuKerros;
        Console.WriteLine($"Siirrytty kerrokseen {Kerros}.");
    }
}

class Program
{
    static void Main()
    {
        Hissi hissi = new Hissi();

        while (true)
        {
            Console.Write("Valitse kerros (1 - 6): ");
            if (int.TryParse(Console.ReadLine(), out int haluttuKerros))
            {
                hissi.MeneKerrokseen(haluttuKerros);
            }
            else
            {
                Console.WriteLine("Virheellinen syöte! Anna kokonaisluku väliltä 1 - 6.");
            }
        }
    }
}