﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class StudentCard
{
    public int Number { get; set; }
    public string Series { get; set; }
    public override string ToString()
    {
        return $"Студенческий билет: { Series} { Number}";
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard StudentCard { get; set; }
    public override string ToString() 
    {
        return $"Student: {FirstName}, {LastName}, {BirthDate}, {StudentCard}";
    }
}

class Auditory : IEnumerable
{
        Student[] students =
            {
            new Student 
            {
            FirstName ="John",
            LastName ="Miller",
            BirthDate =new DateTime(1997,3,12),
            StudentCard =new StudentCard { Number=189356,
            Series="AB" }
            },
            new Student 
            {
            FirstName ="Candice",
            LastName ="Leman",
            BirthDate =new DateTime(1998,7,22),
            StudentCard = new StudentCard { Number=345185,
            Series="XA" }
            },
            new Student 
            {
            FirstName ="Joey",
            LastName ="Finch",
            BirthDate = new DateTime(1996,11,30),
            StudentCard = new StudentCard { Number=258322,
            Series="AA" }
            },
            new Student 
            {
            FirstName ="Nicole",
            LastName ="Taylor",
            BirthDate = new DateTime(1996,5,10),
            StudentCard = new StudentCard { Number=513484,
            Series="AA" }
            }
        };

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Auditory auditory = new Auditory();
        WriteLine("\n++++++++ список студентов++++++++\n");
        foreach (Student student in auditory)
        {
            WriteLine(student);
        }
    }
}
