using NeedForVkid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SpeedTester
{
    public delegate void spdtstr(string message);
    public event spdtstr MyEvent;

    public void OnMyEvent(string message)
    {
        Console.WriteLine($"Скорость превышена на: {message}");
    }

    public void TriggerEvent(string message)
    {
        MyEvent?.Invoke(message);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int speedlimit = 80;
        Avtomobil obj = new Avtomobil(5, 2, "be222bra");

        while (true)
        {
            obj.speed += obj.accel;
            if (obj.speed > speedlimit)
            {
                double excessSpeed = obj.speed - speedlimit;
                string skr = excessSpeed.ToString();

                SpeedTester tester = new SpeedTester();
                tester.MyEvent += tester.OnMyEvent;

                tester.TriggerEvent(skr);
                Console.WriteLine(obj.idNumber);
                break;
            }
        }
    }
}