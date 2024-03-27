using System;

class Kiuas
{
    private double lämpötila;
    private double kosteus;

    public Kiuas()
    {
        this.lämpötila = 20; 
        this.kosteus = 50;   
    }

    public void KytkePäälle()
    {
        Console.WriteLine("Kiuas on päällä.");
    }

    public void KytkePois()
    {
        Console.WriteLine("Kiuas on pois päältä.");
    }

    public void AsetaLämpötila(double lämpötila)
    {
        this.lämpötila = lämpötila;
        Console.WriteLine($"Lämpötila asetettu: {lämpötila}°C.");
    }

    public void AsetaKosteus(double kosteus)
    {
        this.kosteus = kosteus;
        Console.WriteLine($"Kosteus asetettu: {kosteus}%.");
    }

    public void NäytäTila()
    {
        Console.WriteLine($"Nykyinen lämpötila: {lämpötila}°C");
        Console.WriteLine($"Nykyinen kosteus: {kosteus}%");
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Kiuas kiuas = new Kiuas();

        kiuas.KytkePäälle();

        kiuas.AsetaLämpötila(80);
        kiuas.AsetaKosteus(70);

        kiuas.NäytäTila();

        
    }
}