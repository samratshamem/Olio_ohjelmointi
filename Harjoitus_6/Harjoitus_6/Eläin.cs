using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Eläin
    {
        public string Nimi { get; set; }  

        private static int instanssit = 0;  

        public Eläin()
        {
            instanssit++;
        }
        

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä luotu " + instanssit);

        }

        public virtual void Ääntele()
        {
            Console.WriteLine("Eläin Ääntelee");
        } 
    }
}
