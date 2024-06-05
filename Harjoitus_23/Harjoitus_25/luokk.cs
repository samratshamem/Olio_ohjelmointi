using System.Collections.Generic;

public class Pelaaja
{
    public string Etunimi { get; set; }
    public string Sukunimi { get; set; }
    public int PelaajaNumero { get; set; }
    public string Joukkue { get; set; }
}

public class Joukkue
{
    public string Nimi { get; set; }
    public string Kotikaupunki { get; set; }
    public List<Pelaaja> Pelaajat { get; set; } = new List<Pelaaja>();
}
