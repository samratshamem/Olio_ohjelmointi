using System;

namespace Harjoitus_1
{

   class Program
   {
       static void Main(string[] args)
       {
          Ajoneuvo auto = new Ajoneuvo();
          auto.Nimi = "Toyota";
          auto.Nopeus = 80;
          auto.Renkaat = 4;

            auto.TulostaData();

            string autonTiedot = auto.ToString();
            Console.WriteLine(autonTiedot);

            Console.WriteLine();

            Ajoneuvo orava = new Ajoneuvo();
            orava.Nimi = "BMW";
            orava.Nopeus = 160;
            orava.Renkaat = 3;

            orava.TulostaData();
            Console.WriteLine(orava.ToString());
       }
   }
}
   