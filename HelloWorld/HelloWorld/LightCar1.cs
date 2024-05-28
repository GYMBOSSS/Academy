using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class LightCar : Car
    {
        public LightCar(string pname, int plife, int pspeed) : base(pname, plife, pspeed) { }
        public double Nitro;
    }
}
