using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            //var allSymbols = new string(input.Where(x => !char.IsDigit(x)).ToArray());
            var uniqueSymbols = new Dictionary<char, int>();
            string pattern = @"([^\d]+)(\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();
            foreach (Match item in matches)
            {
                string characters = item.Groups[1].ToString();
                int repeatString = int.Parse(item.Groups[2].ToString());
                if (repeatString == 0)
                    continue;
                for (int i = 0; i < characters.Length; i++)
                {
                    var currentElement = characters[i];
                    if (!uniqueSymbols.ContainsKey(currentElement))
                    {
                        uniqueSymbols[currentElement] = 1;
                    }
                }
                for (int i = 0; i < repeatString; i++)
                {
                    sb.Append(characters);
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Keys.Count}");

            Console.WriteLine(sb.ToString());
        }
    }
}