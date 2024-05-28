using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class HeavyCar : Car
    {
        public int Cargo;
        public HeavyCar(string pname, int plife, int pspeed) : base(pname, plife, pspeed) { }
    }
}
