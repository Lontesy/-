using System;
using System.Diagnostics;
namespace LR_10
{
    class Program
    {
        public static int Factorial(int n)
        {
            if (n == 1 || n == 0) return 1;           
            
              n *= Factorial(n - 1);          
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(500));
        }
    }
}
