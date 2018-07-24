using System;

namespace _02.NumberChecker
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                long integer = long.Parse(input);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
