using System;

abstract class Henkilo
{
    public string Nimi { get; set; }
    public string Tyopaikka { get; set; }
    public decimal Palkka { get; set; }

    public Henkilo(string nimi, string tyopaikka, decimal palkka)
    {
        Nimi = nimi;
        Tyopaikka = tyopaikka;
        Palkka = palkka;
    }

    public abstract void TulostaTiedot();
}

class Tyontekija : Henkilo
{
    public int Viikkotunnit { get; set; }

    public Tyontekija(string nimi, string tyopaikka, decimal palkka, int viikkotunnit)
        : base(nimi, tyopaikka, palkka)
    {
        Viikkotunnit = viikkotunnit;
    }

    public override void TulostaTiedot()
    {
        Console.WriteLine($"Työntekijä {Nimi}, työpaikka: {Tyopaikka}, palkka: {Palkka:C}, viikkotunnit: {Viikkotunnit}");
    }
}

class Pomo : Henkilo
{
    public decimal Boonus { get; set; }
    public string AutonMerkki { get; set; }

    public Pomo(string nimi, string tyopaikka, decimal palkka, decimal boonus, string autonMerkki)
        : base(nimi, tyopaikka, palkka)
    {
        Boonus = boonus;
        AutonMerkki = autonMerkki;
    }

    public override void TulostaTiedot()
    {
        Console.WriteLine($"Pomo {Nimi}, työpaikka: {Tyopaikka}, palkka: {Palkka:C}, bonus: {Boonus:C}, auton merkki: {AutonMerkki}");
    }
}

class Ohjelma
{
    static void Main()
    {
        Henkilo henkilo = new Tyontekija("Matti Meikäläinen", "Firma Oy", 3500, 40);
        Henkilo johtaja = new Pomo("Markus Johtaja", "Johto Oy", 8000, 2000, "BMW");

        henkilo.TulostaTiedot();
        johtaja.TulostaTiedot();
    }
}