using System;
using System.Collections.Generic;
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
            while ((input = Console.ReadLine()) != "Visual Studio crash")
            {
                sb.Append(input + " ");
            }

            string pattern = @"32656 19759 32763 0 ([0-9]+) (0)";
            string result = sb.ToString();
            foreach (Match m in Regex.Matches(result, pattern))
            {
                int startIndex = m.Groups[2].Index + 2;
                int count = int.Parse(m.Groups[1].Value);
                List<long> digits = new List<long>();

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
