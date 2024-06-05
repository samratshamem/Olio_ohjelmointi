using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    internal interface ICanFly
    {

        public float WingSize { get; set; }
        public void Fly();
    }
}
