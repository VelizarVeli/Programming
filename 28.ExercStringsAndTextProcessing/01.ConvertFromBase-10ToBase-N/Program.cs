using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split().ToArray();
            int system = int.Parse(str[0]);
            string input = str[1];
            BigInteger number = BigInteger.Parse(input);
            int length = input.Length;
            var result = new StringBuilder(length);

            while (number != 0)
            {
                result.Append(number % system);
                number /= system;
            }
            string res = result.ToString();
            string revResult = ReverseString(res);
            Console.WriteLine(revResult);
        }
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
