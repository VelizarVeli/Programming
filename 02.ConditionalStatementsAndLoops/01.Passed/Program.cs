using System;

namespace _01.Passed
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
        }
    }
}
