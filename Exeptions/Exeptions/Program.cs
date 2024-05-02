using System;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void Main()
        {
            int num1, num2, res = 0;

            WriteLine("Введите два числа, чтобы узнать их разность: ");

            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                res = num1 / num2;

                WriteLine("Разность равна " + res);
            }
            catch (DivideByZeroException ex) { WriteLine(ex.Message); return; }
            catch (Exception ex) { WriteLine(ex.ToString()); return; }
            finally { WriteLine("Finally end"); }
            WriteLine("end");
            throw new ArgumentException("Error witn args");
        }
    }
}