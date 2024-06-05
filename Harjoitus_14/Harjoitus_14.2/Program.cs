
using System;
using System.IO;

class Program
{
    static string filePath = "muistiinpanot.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Valitse toiminto: Uusi muistiinpano, Tulosta muistiinpanot, Tyhjennä muistiinpanot");
            string command = Console.ReadLine();

            switch (command)
            {
                case "Uusi muistiinpano":
                    NewNote();
                    break;
                case "Tulosta muistiinpanot":
                    PrintNotes();
                    break;
                case "Tyhjennä muistiinpanot":
                    ClearNotes();
                    break;
                default:
                    Console.WriteLine("Tuntematon komento.");
                    break;
            }
        }
    }

    static void NewNote()
    {
        Console.WriteLine("Kirjoita uusi muistiinpano:");
        string note = Console.ReadLine();
        File.AppendAllText(filePath, note + Environment.NewLine);
    }

    static void PrintNotes()
    {
        try
        {
            string notes = File.ReadAllText(filePath);
            Console.WriteLine(notes);
        }
        catch (Exception e)
        {
            Console.WriteLine("Virhe: " + e.Message);
        }
    }

    static void ClearNotes()
    {
        try
        {
            File.WriteAllText(filePath, string.Empty);
        }
        catch (Exception e)
        {
            Console.WriteLine("Virhe: " + e.Message);
        }
    }
}