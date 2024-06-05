using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    internal interface ICanSwim
    {

        public int SwimSpeed { get; set; }
        public void Swim();
    }
}
