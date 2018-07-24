using System;

namespace _02.PassedOrFailed
{
    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            if (num >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}