using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Football_League
{

    class Program
    {
        static void Main()
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            var regex = $@"{key}(?<teamOne>.*?){key}.+?{key}(?<teamTwo>.*?){key}.+?(?<teamOneGoals>\d+):(?<teamTwoGoals>\d+)";
            var inputInfo = Console.ReadLine();
            var teamsTable = new Dictionary<string, int>();
            var goalScorers = new Dictionary<string, int>();

            while (inputInfo != "final")
            {
                MatchCollection matchInfo = Regex.Matches(inputInfo, regex);

                foreach (Match match in matchInfo)
                {
                    var teamOne = new string(match.Groups["teamOne"].Value.Reverse().ToArray()).ToUpper();
                    var teamTwo = new string(match.Groups["teamTwo"].Value.Reverse().ToArray()).ToUpper();
                    var teamOneGoals = int.Parse(match.Groups["teamOneGoals"].Value);
                    var teamTwoGoals = int.Parse(match.Groups["teamTwoGoals"].Value);

                    var teamOnePoints = 0;
                    var teamTwoPoints = 0;
                    if (teamOneGoals > teamTwoGoals)
                    {
                        teamOnePoints = 3;
                        teamTwoPoints = 0;
                    }
                    else if (teamOneGoals < teamTwoGoals)
                    {
                        teamOnePoints = 0;
                        teamTwoPoints = 3;
                    }
                    else
                    {
                        teamOnePoints = 1;
                        teamTwoPoints = 1;
                    }

                    if (!teamsTable.ContainsKey(teamOne))
                    {
                        teamsTable[teamOne] = 0;

                    }

                    if (!teamsTable.ContainsKey(teamTwo))
                    {
                        teamsTable[teamTwo] = 0;
                    }

                    teamsTable[teamOne] += teamOnePoints;
                    teamsTable[teamTwo] += teamTwoPoints;


                    if (!goalScorers.ContainsKey(teamOne))
                    {
                        goalScorers[teamOne] = 0;

                    }
                    if (!goalScorers.ContainsKey(teamTwo))
                    {
                        goalScorers[teamTwo] = 0;
                    }

                    goalScorers[teamOne] += teamOneGoals;
                    goalScorers[teamTwo] += teamTwoGoals;

                }

                inputInfo = Console.ReadLine();
            }
            var postion = 1;
            Console.WriteLine("League standings:");
            foreach (var team in teamsTable.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {

                var teamName = team.Key;
                var teamPoints = team.Value;

                Console.WriteLine($"{postion++}. {teamName} {teamPoints}");

            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var goals in goalScorers.OrderByDescending(g => g.Value).ThenBy(g => g.Key).Take(3))
            {
                var teamName = goals.Key;
                var teamGoals = goals.Value;

                Console.WriteLine($"- {teamName} -> {teamGoals}");
            }
        }
    }
}