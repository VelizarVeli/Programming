using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] key = Console.ReadLine().Split(new char[] { '<', '|', '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string start = key[0];
            string end = key[1];

            var pattern = new Regex(@"({start})(?<word>\w)+?({end})");

            string input = Console.ReadLine();

            var wordMatch = pattern.Matches(input);

            foreach (Match word in wordMatch)
            {
                Console.WriteLine(word.Value);
            }


            //var word = wordMatch.Groups["word"].Value;





          //foreach (Match m in Regex.Matches(input, pattern))
          //{
          //    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
          //}
        }
    }
}
