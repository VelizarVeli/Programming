using System;
using System.Text.RegularExpressions;

namespace _03._6._9July2017
{
    class Program
    {
        static void Main()
        {
            string DidimonMatch = @"[^a-zA-Z-]+";
            string RegexmonMatch = @"[a-zA-Z]+-[a-zA-Z]+";
            string input = Console.ReadLine();
           

            while (true)
            {
                Regex DidimonRegex = new Regex(DidimonMatch, RegexOptions.IgnoreCase);
                Match Didimon = DidimonRegex.Match(input);

                if (Didimon.Success)
                {
                    Console.WriteLine(Didimon);
                    int ind = Didimon.Length;
                    input = input.Substring(Didimon.Index + ind);
                }
                else
                {
                    break;
                }

                Regex RegexmonRegex = new Regex(RegexmonMatch, RegexOptions.IgnoreCase);
                Match Regexmon = RegexmonRegex.Match(input);

                if (Regexmon.Success)
                {
                    Console.WriteLine(Regexmon);
                    int ind = Regexmon.Length;
                    input = input.Substring(Regexmon.Index + ind);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
