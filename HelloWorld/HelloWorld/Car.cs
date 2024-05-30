using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal abstract class Car
    {
        public delegate bool Damaged(int dmg);
        public event Damaged? HitFromThePit;
        public int Life { get; set; }
        public int Speed {  get; set; }
        public string Name { get; set; }

        public Car(string pname, int plife, int pspeed)
        {
            Life = plife;
            Speed = pspeed;
            Name = pname;
        }

        public Car(string pname) : this(pname, 30, 1) { }
    }
}
