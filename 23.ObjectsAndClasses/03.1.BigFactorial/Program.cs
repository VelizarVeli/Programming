using System;
using System.Numerics;

namespace _03._1.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
