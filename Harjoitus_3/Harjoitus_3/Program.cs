using System;

class Kiuas
{
    private bool _onkoPäälla;
    private double _lampotila;
    private double _kosteus;

    public Kiuas()
    {
        _onkoPäälla = false;
        _lampotila = 20.0; 
        _kosteus = 50.0; 
    }

    public void LaitaPäälle()
    {
        _onkoPäälla = true;
        Console.WriteLine("Kiuas on päällä.");
    }

    public void LaitaPois()
    {
        _onkoPäälla = false;
        Console.WriteLine("Kiuas on pois päältä.");
    }

    public void KiuasLampotila(double lampotila)
    {
        _lampotila = lampotila;
        Console.WriteLine($"Lämpötila asetettu: {_lampotila}°C");
    }

    public void KiuasKosteus(double kosteus)
    {
        _kosteus = kosteus;
        Console.WriteLine($"Kosteus asetettu: {_kosteus}%");
    }
}

class Ohjelma
{
    static void Main()
    {
        Kiuas kiuas = new Kiuas();

        kiuas.LaitaPäälle();
        kiuas.KiuasLampotila(80.0);
        kiuas.KiuasKosteus(70.0);
        kiuas.LaitaPois();
    }
}