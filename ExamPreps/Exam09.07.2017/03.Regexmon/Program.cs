
namespace _03.Regexmon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string patternDidi = @"[^A-Za-z-]+";
            string patternBojo = @"[A-Za-z]+-[A-Za-z]+";

            Regex regexDidi = new Regex(patternDidi);
            Regex regexBojo = new Regex(patternBojo);

            while (true)
            {
                Match didiMatch = regexDidi.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                Match bojoMatch = regexBojo.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);

            }
        }
    }
}