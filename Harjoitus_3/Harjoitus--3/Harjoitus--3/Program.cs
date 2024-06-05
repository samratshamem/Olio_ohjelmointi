using System;

class Kiuas
{
    private bool päällä;
    private double lämpötila;
    private double kosteus;

    public Kiuas()
    {
        päällä = false;
        lämpötila = 20; // Oletuslämpötila
        kosteus = 50; // Oletuskosteus
    }

    public void Päälle()
    {
        if (!päällä)
        {
            päällä = true;
            Console.WriteLine("Kiuas on nyt päällä.");
        }
        else
        {
            Console.WriteLine("Kiuas on jo päällä.");
        }
    }

    public void Pois()
    {
        if (päällä)
        {
            päällä = false;
            Console.WriteLine("Kiuas on nyt pois päältä.");
        }
        else
        {
            Console.WriteLine("Kiuas on jo pois päältä.");
        }
    }

    public void AsetaLämpötila(double uusiLämpötila)
    {
        lämpötila = uusiLämpötila;
        Console.WriteLine($"Kiuaksen lämpötila asetettu: {lämpötila}°C");
    }

    public void AsetaKosteus(double uusiKosteus)
    {
        kosteus = uusiKosteus;
        Console.WriteLine($"Kiuaksen kosteus asetettu: {kosteus}%");
    }

    public void NäytäTila()
    {
        Console.WriteLine($"Kiuas on {(päällä ? "päällä" : "pois päältä")}, lämpötila: {lämpötila}°C, kosteus: {kosteus}%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kiuas kiuas = new Kiuas();

        kiuas.Päälle();
        kiuas.AsetaLämpötila(70);
        kiuas.AsetaKosteus(60);
        kiuas.NäytäTila();

        kiuas.Pois();
        kiuas.NäytäTila();
    }
}