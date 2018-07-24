using System;

namespace _11.OddNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                do
                {
                    Console.WriteLine("Please write an odd number.");
                    n = int.Parse(Console.ReadLine());


                } while (n % 2 == 0);
            }
            Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
    }
}
