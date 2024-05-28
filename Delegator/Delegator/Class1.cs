using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegator
{
    class Car
    {
        public delegate void CarEventHandler(Car c);
        public event CarEventHandler? collision;
        int Life { get; set; }
        string Name {  get; set; }
        public Car(int life, string name)
        {
            Life = life;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public CarEventHandler? GetCollision()
        {
            return collision;
        }

        public void update(int a, CarEventHandler? collision)
        {
            if (a == 3) { collision.Invoke(this); }
        }
    }
}
