using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._1.TeamworkProjects
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> allTeams = new List<Team>();

            RegisteringTeams(n, allTeams);
            RegisterMembers(allTeams);
            PrintResult(allTeams);
        }

        private static void PrintResult(List<Team> allTeams)
        {
            var teamsOrdered = allTeams.OrderByDescending(a => a.Members.Count).ThenBy(a => a.TeamName).ToList();
            foreach (var team in teamsOrdered)
            {
                if (team.Members.Count != 0)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.CreatorName}");
                }
                foreach (var member in team.Members.OrderBy(a => a))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var disbandTeam in allTeams.OrderBy(a => a.TeamName))
            {
                if (disbandTeam.Members.Count == 0)
                {
                    Console.WriteLine(disbandTeam.TeamName);
                }
            }
        }

        private static void RegisterMembers(List<Team> allTeams)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] inp = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string memberCandidate = inp[0];
                string teamName = inp[1];

                if (!allTeams.Any(a => a.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }   

                if (allTeams.Any(a => a.Members.Contains(memberCandidate) || allTeams.Any(b => b.CreatorName == memberCandidate)))
                {
                    Console.WriteLine($"Member {memberCandidate} cannot join team {teamName}!");
                    continue;
                }

                var lookedTeam = allTeams.First(a => a.TeamName == teamName);
                lookedTeam.Members.Add(memberCandidate);
            }
        }

        private static void RegisteringTeams(int n, List<Team> allTeams)
        {
            for (int i = 0; i < n; i++)
            {
                string[] newTeams = Console.ReadLine().Split('-');
                string creatorName = newTeams[0];
                string teamName = newTeams[1];

                if (allTeams.Any(a => a.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (allTeams.Any(a => a.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                Team createTeam = new Team(creatorName, teamName);
                allTeams.Add(createTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }
        }

        public class Team
        {
            public string CreatorName { get; set; }
            public string TeamName { get; set; }
            public List<string> Members { get; set; }

            public Team(string creatorName, string teamName)
            {
                this.CreatorName = creatorName;
                this.TeamName = teamName;
                this.Members = new List<string>();
            }
        }
    }
}
