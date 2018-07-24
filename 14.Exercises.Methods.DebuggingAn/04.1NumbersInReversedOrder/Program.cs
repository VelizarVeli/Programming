using System;

namespace _4._1NumbersInReversedOrder
{
    class Program
    {
        static decimal ReverseString(decimal number)
        {
            string numToString = number.ToString();

            var result = "";
            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                result += numToString[i];
            }
            return decimal.Parse(result);
            
        }
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversed = ReverseString(number);

            Console.WriteLine(reversed);
        }
    }
}
