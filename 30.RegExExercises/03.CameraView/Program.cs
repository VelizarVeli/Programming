using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int skip = tokens[0];
            int take = tokens[1];

            var pattern = new Regex(@"(?<=\|<)(?<text>\w+)");
            string inputLine = Console.ReadLine();

            var matches = pattern.Matches(inputLine)
                .Cast<Match>()
                .Select(a => a.Groups["text"].Value)
                .ToArray();

            var output = new List<string>();
            foreach (var text in matches)
            {
                if (text.Length >= skip + take)
                {
                    output.Add(text.Substring(skip, take));
                }
                else if (text.Length < skip + take)
                {
                    output.Add(text.Remove(0, skip));
                }
                else if (text.Length <= skip)
                {
                    continue;
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}