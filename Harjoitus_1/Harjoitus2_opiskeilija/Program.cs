using System;

namespace Harjoitus2_opiskeilija
{

    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Matti", "TVT1234", 0);

            opiskelija1.TulostaData();
        }
    }
}