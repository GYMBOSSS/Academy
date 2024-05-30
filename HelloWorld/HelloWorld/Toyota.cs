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
        public int Y { get; set; }
        public int Actiom {  get; set; }
        public Toyota(string pname) : base(pname) { Y = 0; }

        public Toyota(string pname, int plife, int pspeed) : base(pname, plife, pspeed)
        {
            Y = 0;
        }

        public bool HitHandler(int value)
        {
            Life -= value;
            return Life > 0 ? true : false;
        }
        
        public int update_Y()
        {
            //floor 302

            return Y;
        }
    }
}
