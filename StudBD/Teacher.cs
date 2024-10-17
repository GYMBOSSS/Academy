using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudBD
{
    internal class Teacher : Human
    {
        string education;
        string academic_degree;
        string[] subj_taught;
        public Teacher(string name, string surname, string middlename, int age, string phone_number, bool gender, string education, string academic_degree, string[] subj_taught) : base(name, surname, middlename, age, phone_number, gender) 
        {
            this.education = education;
            this.academic_degree = academic_degree;
            this.subj_taught = subj_taught;
        }
    }
}
