using System;
using Delegator;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello world!");

        Car c = new Car(3,"buba");
        c.collision += (Car cur_car) => { Console.WriteLine(cur_car.ToString(), "hitted!"); };

        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("-");
            c.update(rnd.Next(1, 5), c.GetCollision());
        }
    }
}