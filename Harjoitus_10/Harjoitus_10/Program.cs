using System;

namespace Harjoitus_10
{

    class Program
    {
        static void Main(string[] args)
        {
            Varis varis = new Varis("Varis", 90);

            varis.MakeASound();
            varis.Fly();

            Kala ahven = new Kala("Ahven", 50, "Blurps");

            ahven.MakeASound();
            ahven.Swim();

            Sorsa sorsa = new Sorsa("Sorsa", 85, 10);

            sorsa.MakeASound();
            sorsa.Fly();
            sorsa.MakeASound();
            sorsa.Swim();
        }
    }
}