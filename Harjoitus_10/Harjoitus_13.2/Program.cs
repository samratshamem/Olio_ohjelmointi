using System;
using System.Collections.Generic;

public class Pelaaja
{
    public string Etunimi { get; set; }
    public string Sukunimi { get; set; }
    public int PelaajaNumero { get; set; }
}

public class Joukkue
{
    public string Nimi { get; set; }
    public string Kotikaupunki { get; set; }
    private Dictionary<int, Pelaaja> Pelaajat { get; set; }

    public Joukkue()
    {
        Pelaajat = new Dictionary<int, Pelaaja>();
    }

    public Pelaaja HaePelaaja(int numero)
    {
        try
        {
            return Pelaajat[numero];
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Pelaajaa numerolla " + numero + " ei löytynyt.");
            return null;
        }
    }

    public void LisääPelaaja(Pelaaja pelaaja)
    {
        try
        {
            Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
            Console.WriteLine("Pelaaja " + pelaaja.Etunimi + " " + pelaaja.Sukunimi + " lisätty joukkueeseen.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Pelaaja numerolla " + pelaaja.PelaajaNumero + " on jo lisätty joukkueeseen.");
        }
    }

    public void PoistaPelaaja(int numero)
    {
        try
        {
            Pelaajat.Remove(numero);
            Console.WriteLine("Pelaaja numero " + numero + " poistettu joukkueesta.");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Pelaajaa numerolla " + numero + " ei löytynyt.");
        }
    }

    public List<Pelaaja> HaePelaajat()
    {
        return new List<Pelaaja>(Pelaajat.Values);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Joukkue joukkue = new Joukkue();
        joukkue.Nimi = "Esimerkkijoukkue";
        joukkue.Kotikaupunki = "Esimerkkikaupunki";

        Pelaaja pelaaja1 = new Pelaaja { Etunimi = "Matti", Sukunimi = "Meikäläinen", PelaajaNumero = 10 };
        Pelaaja pelaaja2 = new Pelaaja { Etunimi = "Mikko", Sukunimi = "Mallikas", PelaajaNumero = 20 };

        joukkue.LisääPelaaja(pelaaja1);
        joukkue.LisääPelaaja(pelaaja2);

        Console.WriteLine("Haetaan pelaajaa numerolla 10:");
        Pelaaja haettuPelaaja = joukkue.HaePelaaja(10);
        if (haettuPelaaja != null)
        {
            Console.WriteLine("Haettu pelaaja: " + haettuPelaaja.Etunimi + " " + haettuPelaaja.Sukunimi);
        }

        Console.WriteLine("Poistetaan pelaaja numerolla 20:");
        joukkue.PoistaPelaaja(20);

        Console.WriteLine("Pelaajat joukkueessa:");
        List<Pelaaja> pelaajat = joukkue.HaePelaajat();
        foreach (var pelaaja in pelaajat)
        {
            Console.WriteLine(pelaaja.Etunimi + " " + pelaaja.Sukunimi);
        }
    }
}