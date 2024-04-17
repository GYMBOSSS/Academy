using System;
using System.Security.Cryptography;

class Program
{
    static void printArr(string[,] arr)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j]);
                Console.Write("   ");
            }
            Console.WriteLine("\n");
        }
    }

    static bool checkWin(string[,] pole, string player)
    {
        // Проверка по горизонтали
        for (int i = 0; i < 3; i++)
        {
            if (pole[i, 0] == player && pole[i, 1] == player && pole[i, 2] == player)
            {
                return true;
            }
        }

        // Проверка по вертикали
        for (int j = 0; j < 3; j++)
        {
            if (pole[0, j] == player && pole[1, j] == player && pole[2, j] == player)
            {
                return true;
            }
        }

        // Проверка по диагоналям
        if (pole[0, 0] == player && pole[1, 1] == player && pole[2, 2] == player)
        {
            return true;
        }
        if (pole[0, 2] == player && pole[1, 1] == player && pole[2, 0] == player)
        {
            return true;
        }

        return false;
    }

    static bool checkTie(string[,] pole)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (pole[i, j] == "*")
                {
                    return false;
                }
            }
        }

        return true;
    }
    static void Main()
    {
        Console.WriteLine("Введите символ игрока 1");
        string p1 = Console.ReadLine();
        Console.WriteLine("Введите символ игрока 2");
        string p2 = Console.ReadLine();
        string[,] _ref = new string[,] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
        string[,] pole = _ref;
        int[] array1 = new int[2];
        string[] array2 = new string[2];
        string txt;
        bool gameOver = false;

        while (!gameOver)
        {
            printArr(pole);
            Console.WriteLine("Ход игрока 1(напишите координаты через пробел)");
            txt = Console.ReadLine();
            array2 = txt.Split(" ");

            // Проверка на корректность ввода
            if (array2.Length != 2 || !int.TryParse(array2[0], out array1[0]) || !int.TryParse(array2[1], out array1[1]) || array1[0] < 0 || array1[0] > 2 || array1[1] < 0 || array1[1] > 2)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите координаты через пробел.");
                continue;
            }

            // Проверка на занятость клетки
            if (pole[array1[0], array1[1]] != "*")
            {
                Console.WriteLine("Эта клетка уже занята. Пожалуйста, выберите другую.");
                continue;
            }

            pole[array1[0], array1[1]] = p1;

            // Проверка на победу или ничью
            if (checkWin(pole, p1))
            {
                gameOver = true;
                Console.WriteLine("Игрок 1 победил!");
                break;
            }
            else if (checkTie(pole))
            {
                gameOver = true;
                Console.WriteLine("Ничья!");
                break;
            }

            printArr(pole);
            Console.WriteLine("Ход игрока 2(напишите координаты через пробел)");
            txt = Console.ReadLine();
            array2 = txt.Split(" ");

            // Проверка на корректность ввода
            if (array2.Length != 2 || !int.TryParse(array2[0], out array1[0]) || !int.TryParse(array2[1], out array1[1]) || array1[0] < 0 || array1[0] > 2 || array1[1] < 0 || array1[1] > 2)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите координаты через пробел.");
                continue;
            }

            // Проверка на занятость клетки
            if (pole[array1[0], array1[1]] != "*")
            {
                Console.WriteLine("Эта клетка уже занята. Пожалуйста, выберите другую.");
                continue;
            }

            pole[array1[0], array1[1]] = p2;

            // Проверка на победу или ничью
            if (checkWin(pole, p2))
            {
                gameOver = true;
                Console.WriteLine("Игрок 2 победил!");
                break;
            }
            else if (checkTie(pole))
            {
                gameOver = true;
                Console.WriteLine("Ничья!");
                break;
            }
        }
    }
}