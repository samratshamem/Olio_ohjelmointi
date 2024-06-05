using System;
using System.Collections.Generic;

class Opiskelija
{
    public string Etunimi { get; set; }
    public string Sukunimi { get; set; }
    public string Ryhmätunnus { get; set; }
    public string OpiskelijaID { get; set; }

    public Opiskelija(string etunimi, string sukunimi, string ryhmätunnus, string opiskelijaID)
    {
        Etunimi = etunimi;
        Sukunimi = sukunimi;
        Ryhmätunnus = ryhmätunnus;
        OpiskelijaID = opiskelijaID;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();

        while (true)
        {
            Console.WriteLine("Valitse toiminto: lisää, poista, tulosta tai poistu");
            string komento = Console.ReadLine().ToLower();

            switch (komento)
            {
                case "lisää":
                    LisääOpiskelija(opiskelijat);
                    break;
                case "poista":
                    PoistaOpiskelija(opiskelijat);
                    break;
                case "tulosta":
                    TulostaOpiskelijat(opiskelijat);
                    break;
                case "poistu":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Virheellinen komento. Yritä uudelleen.");
                    break;
            }
        }
    }

    static void LisääOpiskelija(Dictionary<string, Opiskelija> opiskelijat)
    {
        Console.Write("Etunimi: ");
        string etunimi = Console.ReadLine();
        Console.Write("Sukunimi: ");
        string sukunimi = Console.ReadLine();
        Console.Write("Ryhmätunnus: ");
        string ryhmätunnus = Console.ReadLine();
        Console.Write("OpiskelijaID: ");
        string opiskelijaID = Console.ReadLine();

        try
        {
            opiskelijat.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, ryhmätunnus, opiskelijaID));
            Console.WriteLine("Opiskelija lisätty.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("OpiskelijaID on jo käytössä. Yritä uudelleen.");
        }
    }

    static void PoistaOpiskelija(Dictionary<string, Opiskelija> opiskelijat)
    {
        Console.Write("Anna poistettavan opiskelijan OpiskelijaID: ");
        string opiskelijaID = Console.ReadLine();

        if (opiskelijat.ContainsKey(opiskelijaID))
        {
            opiskelijat.Remove(opiskelijaID);
            Console.WriteLine("Opiskelija poistettu.");
        }
        else
        {
            Console.WriteLine("Opiskelijaa ei löytynyt annetulla OpiskelijaID:llä.");
        }
    }

    static void TulostaOpiskelijat(Dictionary<string, Opiskelija> opiskelijat)
    {
        Console.WriteLine("Kaikki opiskelijat:");
        foreach (var opiskelija in opiskelijat.Values)
        {
            Console.WriteLine($"OpiskelijaID: {opiskelija.OpiskelijaID}, Nimi: {opiskelija.Etunimi} {opiskelija.Sukunimi}, Ryhmätunnus: {opiskelija.Ryhmätunnus}");
        }
    }
}