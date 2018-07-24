using System;

namespace _02.SignOfIntegerNumber
{
    class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
