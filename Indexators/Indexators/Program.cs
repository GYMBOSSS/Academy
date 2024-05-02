using System;
using static System.Console;

namespace SimpleProject
{
    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }

    enum Vendors {Sasung,Asis,GL}

    public class Shop
    {
        private Laptop[] laptopArr;

        public Shop(int size) 
        {
            laptopArr = new Laptop[size];
        }

        public int Length
        { 
            get { return laptopArr.Length; }
        }
        public Laptop this[int index] 
        {
            
        }
    }
}

