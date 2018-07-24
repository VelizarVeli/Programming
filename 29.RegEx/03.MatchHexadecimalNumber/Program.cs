using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";

            var numbersString = Console.ReadLine();

            var numbers = Regex.Matches(numbersString, regex).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
