using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.ForceBook04March2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int decryptKey = 0;
            string pattern = @"([^@:!\->]*)@([A-Za-z]+)([^@:!\->]*):([0-9]+)([^@:!\->]*)!([AD])!([^@:!\->]*)->([0-9]+)([^@:!\->]*)";
            string input = "";
            List<Match> attacked = new List<Match>();
            List<Match> destroyed = new List<Match>();


            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                decryptKey = CalculateDecryptKey(input);
                input = DecryptInput(input, decryptKey);
                if (Regex.IsMatch(input, pattern))
                {
                    var current = Regex.Match(input, pattern);
                    if (current.Groups[6].Value == "A")
                    {
                        attacked.Add(current);
                    }
                    else
                    {
                        destroyed.Add(current);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (Match m in attacked.OrderBy(x => x.Groups[2].Value))
            {
                Console.WriteLine($"-> {m.Groups[2].Value}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (Match m in destroyed.OrderBy(x => x.Groups[2].Value))
            {
                Console.WriteLine($"-> {m.Groups[2].Value}");
            }
        }

        static string DecryptInput(string input, int decryptKey)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += (char)(input[i] - decryptKey);
            }
            return result;
        }

        static int CalculateDecryptKey(string input)
        {
            List<char> letters = new List<char>() { 's', 't', 'a', 'r', 'S', 'T', 'A', 'R' };
            int result = input.Count(x => letters.Contains(x));
            return result;
        }
    }
}
