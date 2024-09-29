using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculator
{
    internal class Car
    {
        public int id;
        public byte[] name;
        public byte[] car_type;
        public byte[] fuel_type;
        public double fuel_cons;
        public double avg_speed;

        public Car(int id, byte[] name, byte[] car_type, byte[] fuel_type, double fuel_cons, double avg_speed)
        {
            this.id = id;
            this.name = name;
            this.car_type = car_type;
            this.fuel_type = fuel_type;
            this.fuel_cons = fuel_cons;
            this.avg_speed = avg_speed;
        }

    }
}
