using System;

class Program
{
    static int[] intArray;
    static string[] stringArray;

    static void swap(int[] a, int x, int y)
    {
        int temp = a[x];
        a[x] = a[y];
        a[y] = temp;
    }

    static void printArr(int[] a)
    {
        for (int i = 0; i < a.Length; i++) { Console.Write(a[i]); Console.WriteLine(" "); } ;
    }

    static void bubbleSort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    swap(a,j,j+1);
                }
            }
        }
    }
    static void schet(int[] a, int _x)
    {
        int digitCount = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == _x)
            {
                digitCount++;
            }
        }
        Console.WriteLine($"Цифра {_x} встречается {digitCount} раз(a).");
    }
    static void Main()
    {
        Console.WriteLine("Введите несколько чисел через пробел: ");
        string x = Console.ReadLine();
        stringArray = x.Split(" ");
        intArray = new int[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++) { intArray[i] = int.Parse(stringArray[i]);}
        bubbleSort(intArray); printArr(intArray);
        Console.WriteLine("Введите цифру, чтобы узнать, сколько раз она встречается в массиве: ");
        int y = int.Parse(Console.ReadLine());
        schet(intArray, y);
    }
}