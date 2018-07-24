using System;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static int GetMultipleOfEvenAndOdds (int n)
        {
            n = Math.Abs(n);
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdd = GetSumOfOddDigits(n);
            return sumEvens * sumOdd;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if(lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if(lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(n);
            Console.WriteLine(result);
        }
    }
}
