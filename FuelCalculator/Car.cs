using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculator
{
    internal class Car
    {
        int id;
        string name;
        string fuel_type;
        double fuel_cons;
        double avg_speed;

        public Car(int id, string name, string fuel_type, double fuel_cons, double avg_speed)
        {
            this.id = id;
            this.name = name;
            this.fuel_type = fuel_type;
            this.fuel_cons = fuel_cons;
            this.avg_speed = avg_speed;
        }

    }
}
