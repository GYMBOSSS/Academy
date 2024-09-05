using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForVkid
{
    internal class Mototsikl : Transport
    {
        double spdMult = 1.5;
        public Mototsikl(int accel, int speed, string idNumber) : base(accel, speed, idNumber) { }
    }
}
