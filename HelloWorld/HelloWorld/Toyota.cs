using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Toyota : Car
    {
        public Toyota(string pname) : base(pname) { }

        public Toyota(string pname, int plife, int pspeed) : base(pname, plife, pspeed)
        {
        }

        public bool HitHandler(int value)
        {
            Life -= value;
            return Life > 0 ? true : false;
        }
    }
}
