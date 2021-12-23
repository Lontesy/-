using System;

using System.Collections.Generic;

using System.Text;

namespace ConsoleApp5

{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите X : ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y : ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите R : ");
            uint R = Convert.ToUInt16(Console.ReadLine());

            if (
            (X <= 0 && Y >= 0 && X >= (-1 * R) && Y <= R && (Math.Pow(X + R, 2) + Math.Pow(Y - R, 2) >= Math.Pow(R, 2)))
            ||
            (X >= 0 && Y <= 0 && X <= R && Y >= (-1 * R) && (Math.Pow(X - R, 2) + Math.Pow(Y + R, 2) >= Math.Pow(R, 2)))
            ) Console.WriteLine("Попал!");
            else Console.WriteLine("Не попал!");
        }
    }

    public static class Point
    {
        public static int CheckPoint(int X, int Y, int R)
        {
            if (X <= 0 && Y >= 0 && X >= (-1 * R) && Y <= R && (Math.Pow(X + R, 2) + Math.Pow(Y - R, 2) >= Math.Pow(R, 2))) return 1;
            if (X >= 0 && Y <= 0 && X <= R && Y >= (-1 * R) && (Math.Pow(X - R, 2) + Math.Pow(Y + R, 2) >= Math.Pow(R, 2))) return 2;
            return 3;
        }
    }
}