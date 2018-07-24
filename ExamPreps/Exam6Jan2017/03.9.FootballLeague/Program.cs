using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._9.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            code = Regex.Escape(code);

            string input = Console.ReadLine();
            Dictionary<string,int> scoreTable = new Dictionary<string, int>();
            Dictionary<string,long> goals = new Dictionary<string, long>();
            while (input != "final")
            {
                string[] splittedInput = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string ATeamEncrypted = splittedInput[0];
                string BTeamEncrypted = splittedInput[1];
                string[] score = splittedInput[2].Split(':');
                int ATeamScore = int.Parse(score[0]);
                int BTeamScore = int.Parse(score[1]);

                string pattern = @"([" + code + @"]+)([a-zA-Z]+)\1";
                //([??] +)([a - zA - Z] +)\1
                Match regiLeft = Regex.Match(ATeamEncrypted, pattern);
                Match regiRight = Regex.Match(BTeamEncrypted, pattern);
                string firstTeam = ReverseString(regiLeft.ToString());
                string secondTeam = ReverseString(regiRight.ToString());
                char[] codeTrim = code.ToCharArray();
                firstTeam = firstTeam.Trim(codeTrim).ToUpper();
                secondTeam = secondTeam.Trim(codeTrim).ToUpper();

                int A = 0;
                int B = 0;
                if (ATeamScore == BTeamScore)
                {
                    A = 1;
                    B = 1;
                }
                else if (ATeamScore > BTeamScore)
                {
                    A = 3;
                }
                else
                {
                    B = 3;
                }
                if (!scoreTable.ContainsKey(firstTeam))
                {
                    scoreTable.Add(firstTeam, 0);
                    goals.Add(firstTeam,0);
                }
                if (!scoreTable.ContainsKey(secondTeam))
                {
                    scoreTable.Add(secondTeam,0);
                    goals.Add(secondTeam, 0);

                }
                scoreTable[firstTeam] += A;
                scoreTable[secondTeam] += B;
                goals[firstTeam] += ATeamScore;
                goals[secondTeam] += BTeamScore;
                input = Console.ReadLine();
            }
            Console.WriteLine("League standings:");
            int counter = 1;
            foreach (var teaming in scoreTable.OrderByDescending(k => k.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{counter}. {teaming.Key} {teaming.Value}");
                counter++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in goals.OrderByDescending(a => a.Value).ThenBy(b => b.Key).Take(3))
            {
                Console.WriteLine($" - {team.Key} -> {team.Value}");
            }
        }
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
