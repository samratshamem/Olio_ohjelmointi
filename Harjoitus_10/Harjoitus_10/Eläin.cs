using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    abstract class Eläin
    {

        public string Name {  get; set; }

        public abstract void MakeASound();
    }
}
