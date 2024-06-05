using System;
using System.Collections.Generic;

class Korttipakka
{
    private List<string> kortit;

    public Korttipakka()
    {
        
        kortit = new List<string>
        {
            "Hertta 2", "Hertta 3", "Hertta 4", 
            "Ruutu Ässä", "Pata Kuningas", "Risti 10"
        };
    }

    public void TulostaKortit()
    {
        foreach (var kortti in kortit)
        {
            Console.WriteLine(kortti);
        }
    }

    public void SekoitaKortit()
    {
        Random random = new Random();
        int n = kortit.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string temp = kortit[k];
            kortit[k] = kortit[n];
            kortit[n] = temp;
        }
    }
}

class Program
{
    static void Main()
    {
        Korttipakka pakka = new Korttipakka();

        Console.WriteLine("Korttipakka ennen sekoitusta:");
        pakka.TulostaKortit();

        pakka.SekoitaKortit();

        Console.WriteLine("\nKorttipakka sekoituksen jälkeen:");
        pakka.TulostaKortit();
    }
}