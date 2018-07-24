using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//решена за 1 час 80/100, грешка в регекса, "@([A-Za-z]+).*:(\d+).*(!A!|!D!).*->(\d+)"  (не изключваше [^@:!\->]*)
namespace _03.StarEnigma04March2018
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < N; i++)
            {
                char[] codedMessage = Console.ReadLine().ToCharArray();
                int cypher = CountAllLetters(codedMessage);
                string decodedMessage = DecryptMessage(codedMessage, cypher);

                string pattern = @"[^@:!\->]*@([A-Za-z]+)[^@:!\->]*:([0-9]+).*(!A!|!D!).*->(\d+)";

                if (Regex.IsMatch(decodedMessage, pattern))
                {
                    MatchCollection matches = Regex.Matches(decodedMessage, pattern);
                    string planetName = String.Empty;
                    string AD = String.Empty;
                    foreach (Match match in matches)
                    {
                        planetName = match.Groups[1].Value;
                        AD = match.Groups[3].Value;
                    }

                    if (AD == "!D!")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                    else
                    {
                        attackedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(a => a))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(a => a))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static string DecryptMessage(char[] codedMessage, int cypher)
        {
            StringBuilder stringi = new StringBuilder();
            for (int i = 0; i < codedMessage.Length; i++)
            {
                codedMessage[i] -= (char)cypher;
                stringi.Append(codedMessage[i]);
            }

            return stringi.ToString();
        }

        private static int CountAllLetters(char[] codedMessage)
        {
            int counter = 0;

            foreach (var chr in codedMessage)
            {
                if (chr == 's' || chr == 'S' || chr == 't' || chr == 'T' || chr == 'a' || chr == 'A' || chr == 'r' || chr == 'R')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
