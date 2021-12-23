using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        public static void Main(string[] args)
        {

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
