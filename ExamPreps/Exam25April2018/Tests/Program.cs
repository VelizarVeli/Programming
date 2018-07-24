using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MemoryView
{
    class Program
    {
        static void Main()
        {
            string input;
            var sb = new StringBuilder();
            List<int> listing = new List<int>();
            while ((input = Console.ReadLine()) != "Visual Studio crash")
            {
                sb.Append(input + " ");
            }

            string pattern = @"32656 19759 32763 0 ([\d]) ([0]) ";

            string result = sb.ToString();
            int[] inp = result.Split(new[] { ' ', '\t' }).Select(int.Parse).ToArray();

            foreach (Match m in Regex.Matches(result, pattern))
            {
                int startIndex = m.Groups[2].Index + 2;
                int count = int.Parse(m.Groups[1].Value);
                List<int> digits = new List<int>();

                string currentDigit = String.Empty;
                while (count != 0)
                {
                    char currentChar = result[startIndex];
                    if (Char.IsDigit(currentChar))
                    {
                        currentDigit = currentDigit + currentChar;
                        startIndex++;
                    }
                    else
                    {
                        count--;
                        startIndex++;
                        digits.Add(int.Parse(currentDigit));
                        currentDigit = String.Empty;
                    }
                }

                foreach (var digit in digits)
                {
                    Console.Write((char)digit);
                }

                Console.WriteLine();
            }
        }
    }
}
