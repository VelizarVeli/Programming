using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string digit = input[i];
                string frontLetter = digit.Substring(0,1);
                string backLetter = digit.Substring(digit.Length - 1);
                string str = digit.Substring(1);
                string str1 = str.Substring(0,str.Length - 1);
                decimal number = decimal.Parse(str1);
                if (Char.IsUpper(frontLetter[0]))
                {
                    char front = char.Parse(frontLetter);
                    number /= (front - 64);
                }
                else
                {
                    char front = char.Parse(frontLetter);
                    number *= (front - 96);
                }
                if (Char.IsUpper(backLetter[0]))
                {
                    char end = char.Parse(backLetter);
                    number -= (end - 64);
                }
                else
                {
                    char end = char.Parse(backLetter);
                    number += (end - 96);
                }
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
