using System;

namespace _12.NumberChecker
{
    class Program
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    } 
}
