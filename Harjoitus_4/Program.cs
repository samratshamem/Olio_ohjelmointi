using System;
using System.Collections.Generic;

class Kappale
{
    public string Nimi { get; }
    public string Artisti { get; }
    public TimeSpan Kesto { get; }

    public Kappale(string nimi, string artisti, TimeSpan kesto)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kesto = kesto;
    }

    public override string ToString()
    {
        return $"Nimi: {Nimi},- {Artisti} {Kesto}";
    }
}

class Albumi
{
    public string Nimi { get; }
    private List<Kappale> kappaleet;

    public Albumi(string nimi)
    {
        Nimi = nimi;
        kappaleet = new List<Kappale>();
    }

    public void LisääKappale(Kappale kappale)
    {
        kappaleet.Add(kappale);
    }

    public void TulostaAlbumi()
    {
        Console.WriteLine($"Albumi: {Nimi}");
        Console.WriteLine("-Artisti: imagine dragon" );
        Console.WriteLine("-Nimi: Evolve");
        Console.WriteLine("-Generate: pop rock");
        Console.WriteLine("Hinta: 10e");
        Console.WriteLine();
        Console.WriteLine("songs:");
        foreach (var kappale in kappaleet)
        {
            Console.WriteLine(kappale.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Albumi albumi = new Albumi("");

        albumi.LisääKappale(new Kappale("Next to me", " ", TimeSpan.FromMinutes(3.5)));
        albumi.LisääKappale(new Kappale("Whatever", " ", TimeSpan.FromMinutes(4.2)));
        albumi.LisääKappale(new Kappale("Thunder", " ", TimeSpan.FromMinutes(5.1)));

        albumi.TulostaAlbumi();
    }
}