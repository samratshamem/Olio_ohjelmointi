using System;
using System.IO;

namespace Harjoitus_14
{

    class Program
    {
        static void Main(string[] args)
        {
            string lukija;
            string filePath = "harjoitus_14";

            try
            {
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine("Muistiinpanot: ");
                    }
                }

                bool Poistutaanko = false;

                while (!Poistutaanko)
                {
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("Anna komento (Lisää, Näytä, Poista, Poistu) > ");
                    lukija = Console.ReadLine().ToLower();

                    switch (lukija)
                    {
                        case "lisää":
                            LisääMuistiinpano(filePath);
                            break;
                        case "näytä":
                            Näytämuistiinpanot(filePath);
                            break;
                        case "poista":
                            Poistamuistiinpanot(filePath);
                            break;
                        case "poistu":
                            Poistutaanko = true;
                            return;
                        default:
                            Console.WriteLine("Annettu komento on virheellinen, anna uusi komento!");
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void LisääMuistiinpano(string filePath)
        {
            string lukija = "";

            Console.WriteLine("Kirjoita Uusi muistiinpano: ");
            Console.WriteLine();
            lukija = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(lukija);
            }
        }

        static void Poistamuistiinpanot(string filePath)
        {
            File.WriteAllText(filePath, "Muistiinpanot: ");
        }

        static void Näytämuistiinpanot(string filePath)
        {
            Console.WriteLine();
            string[] rivit = File.ReadAllLines(filePath);

            foreach (string rivi in rivit)
            {
                Console.WriteLine(rivi);
            }

        }
    }
}