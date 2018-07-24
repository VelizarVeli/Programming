using System;

namespace PrimeChecker
{
    public class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            bool prime = true;
            if (number == 0 || number == 1)
                prime = false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
    }
}
