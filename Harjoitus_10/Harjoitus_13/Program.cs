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
            Console.WriteLine("Pelaajaa ei löytynyt " + numero);
            return null;
        }
    }

    public void LisääPelaaja(Pelaaja pelaaja)
    {
        if (Pelaajat.ContainsKey(pelaaja.PelaajaNumero))
        {
            Console.WriteLine("Pelaajan numero " + pelaaja.PelaajaNumero + " on jo joukkueessa.");
        }
        else
        {
            Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
            Console.WriteLine("Pelaaja " + pelaaja.Etunimi + " " + pelaaja.Sukunimi + " lisätty joukkueeseen.");
        }
    }

    public void PoistaPelaaja(int numero)
    {
        try
        {
            Pelaajat.Remove(numero);
            Console.WriteLine("Pelaajan numero " + numero + " poistettu joukkueesta.");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Pelaajaa ei lötynyt " + numero);
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

        Pelaaja pelaaja1 = new Pelaaja { Etunimi = "Matti", Sukunimi = "Meikäläinen", PelaajaNumero = 1 };
        Pelaaja pelaaja2 = new Pelaaja { Etunimi = "Mikko", Sukunimi = "Mallikas", PelaajaNumero = 2 };

        joukkue.LisääPelaaja(pelaaja1);
        joukkue.LisääPelaaja(pelaaja2);

        Console.WriteLine("Joukkueen pelaajat:");
        foreach (Pelaaja pelaaja in joukkue.HaePelaajat())
        {
            Console.WriteLine(pelaaja.Etunimi + " " + pelaaja.Sukunimi + ", numero " + pelaaja.PelaajaNumero);
        }

        int etsittäväNumero = 1;
        Pelaaja etsittyPelaaja = joukkue.HaePelaaja(etsittäväNumero);
        if (etsittyPelaaja != null)
        {
            Console.WriteLine("Löydetty pelaaja: " + etsittyPelaaja.Etunimi + " " + etsittyPelaaja.Sukunimi);
            joukkue.PoistaPelaaja(etsittäväNumero);
        }

        Console.WriteLine("Jäljelle jääneet pelaajat:");
        foreach (Pelaaja pelaaja in joukkue.HaePelaajat())
        {
            Console.WriteLine(pelaaja.Etunimi + " " + pelaaja.Sukunimi + ", numero " + pelaaja.PelaajaNumero);
        }
    }
}