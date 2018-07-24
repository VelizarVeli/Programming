using System;
using System.Linq;
using System.Numerics;

namespace _02.ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int bases = int.Parse(input[0]);
            string number = input[1];
            BigInteger result = 0;
            int n = 0;
            while (number.Length != 0)
            {
                int digit = int.Parse(number.Substring(number.Length - 1));
                result += digit * BigInteger.Pow(bases, n);
                n++;
                number = number.Substring(0, number.Length - 1);
            }
            Console.WriteLine(result);
        }
    }
}
