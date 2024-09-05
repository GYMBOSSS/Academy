using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForVkid
{
    internal class Transport
    {
        public int accel;
        public double speed;
        double spdMult = 1;
        public string idNumber;

        public Transport(int accel, int speed, string idNumber)
        {
            this.accel = accel;
            this.speed = speed * spdMult;
            this.idNumber = idNumber;
        }
        public Transport() 
        {
            accel = 2;
            speed = 0;
            idNumber = "pe322nis";
        }
    }
}
