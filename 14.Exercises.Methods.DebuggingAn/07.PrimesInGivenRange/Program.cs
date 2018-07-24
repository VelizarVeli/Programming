using System;

namespace _07.PrimesInGivenRange
{
    using System;

    public class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());
            string primery = "";

            for (long i = number1; i <= number2; i++)
            {

                bool prime = IsPrime(i);
                if (prime)
                {
                    primery += i + "," + " ";
                }
            }
            string primery1 = primery.Remove(primery.Length - 2);

            Console.WriteLine(primery1);
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