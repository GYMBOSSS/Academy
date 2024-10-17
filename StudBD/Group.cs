using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudBD
{
    internal class Group
    {
        public string title;
        public int course;
        public string[] subjects;
        public Student[] students;
        public string studyDirection;
        public string studyDegree;
        public Group(string title, int course, string[] subjects, Student[] students, string studyDirection, string studyDegree) 
        {
            this.title = title;
            this.course = course;
            this.subjects = subjects;
            this.students = students;
            this.studyDirection = studyDirection;
            this.studyDegree = studyDegree;
        }
    }
}
