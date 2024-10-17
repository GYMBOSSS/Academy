using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudBD
{
    internal abstract class Human
    {
        string name;
        string surname;
        string middlename;
        int age;
        string phone_number;
        bool gender;

        public Human(string name, string surname, string middlename, int age, string phone_number, bool gender) 
        {
            this.name = name;
            this.surname = surname;
            this.middlename = middlename;
            this.age = age;
            this.phone_number = phone_number;
            this.gender = gender;
        }
    }
}
