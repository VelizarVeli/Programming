using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._1._1._5November2017Again
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] placeholders =
                Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([a-zA-z]+)(.+)\1";
            string patt =    @"([a-zA-Z]+)(.+)\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            MatchCollection matches2 = Regex.Matches(input, patt);


            foreach (Match match in matches)
            {
                Console.WriteLine("Area Code:        {0}", match.Groups[1].Value);
                Console.WriteLine("Area Code:        {0}", match.Groups[1].Value);
                Console.WriteLine("Telephone number: {0}", match.Groups[2].Value);
                Console.WriteLine();
            }
            foreach (Match match in matches2)
            {
                Console.WriteLine("Find Differences:        {0}", match.Groups[1].Value);
                Console.WriteLine();
            }
        }
    }
}
    