using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForVkid
{
    internal class Avtomobil : Transport
    {
        double spdMult = 0.7;
        public Avtomobil(int accel, int speed, string idNumber) : base(accel, speed, idNumber) { }
    }
}
