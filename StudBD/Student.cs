using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudBD
{
    internal class Student : Human
    {
        string adress;
        public Student(string name, string surname, string middlename, int age, string phone_number, bool gender, string adress) : base(name, surname, middlename, age, phone_number, gender)
        {
            this.adress = adress;
        }
    }
}
