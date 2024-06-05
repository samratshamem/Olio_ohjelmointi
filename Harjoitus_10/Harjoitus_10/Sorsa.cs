using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    internal class Sorsa : Eläin, ICanFly, ICanSwim
    {
        public float WingSize { get; set; }
        public int SwimSpeed { get; set; }


        public Sorsa(string _name, float _wingSize, int _swimSpeed)
        {
            Name = _name;
            WingSize = _wingSize;
            SwimSpeed = _swimSpeed; 
        }

        public void Fly()
        {
            Console.WriteLine("{0} Lentää. siipien koko on {1}", Name, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("quack");
        }

        public void Swim()
        {
            Console.WriteLine("{0} ui nopeudella {1}", Name, SwimSpeed);
        }
    }
}
