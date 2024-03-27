using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2_opiskeilija
{
    internal class Opiskelija
    {
        private string Nimi {  get; set; }

        private string opiskelijaID { get; set; }

        private int opintopisteet { get; set;}

        
        public Opiskelija(string nimi, string opiskelijaID, int opintopisteet)
        {
            Nimi = nimi;
            this.opiskelijaID = opiskelijaID;
            this.opintopisteet = opintopisteet;
        }
        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("-- Opiskelijan ID " + opiskelijaID);
            Console.WriteLine("-- Opiskelijapisteet " + opintopisteet);
            Console.WriteLine("");
        }

        public void MuokkaaOpintopisteitä(int i)
        {
            opintopisteet += i;

            if (opintopisteet > 0)
            {
                opintopisteet = 0;
            }
          
        }

    }
}
