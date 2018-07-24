using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger printFact = CalculateFactorial(number);
            Console.WriteLine(printFact);
        }
    }
}
