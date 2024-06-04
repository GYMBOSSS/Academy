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

        
        public Point update_Point(Point _point)
        {
            //floor 302
            int y = Gravity(_point.Y);
            int x = _point.X;

            Point coord = new Point(x, y);
            return coord;
        }
    }
}
