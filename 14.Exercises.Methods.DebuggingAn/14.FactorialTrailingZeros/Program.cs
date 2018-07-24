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

        static int CheckTrailingZeros(BigInteger factorial)
        {
            int counter = 0;
            
            while (true)
            {
                if(factorial % 10 == 0)
                {
                    counter++;
                    factorial /= 10;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger printFact = CalculateFactorial(number);
            int zeros = CheckTrailingZeros(printFact);

            Console.WriteLine(zeros);
        }
    }
}
