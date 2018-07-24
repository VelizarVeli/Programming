using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _04.MOBAChalenger
{
    class Program
    {
        static void Main()
        {
            string input;
            List<Player> players = new List<Player>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                bool check1 = false;
                bool check2 = false;
                string[] splitInput = input.Split(" -> ");
                if (splitInput.Length == 3)
                {
                    string name = splitInput[0];
                    string position = splitInput[1];
                    int skill = int.Parse(splitInput[2]);

                    var currentPlayer = players.FirstOrDefault(a => a.Name == name);

                    if (currentPlayer == null)
                    {
                        Player player = new Player(name, position, skill);
                        players.Add(player);
                    }
                    else
                    {

                        if (!currentPlayer.PositionSkill.ContainsKey(position))
                        {
                            currentPlayer.PositionSkill.Add(position, skill);
                        }

                        if (currentPlayer.PositionSkill[position] < skill)
                        {
                            currentPlayer.PositionSkill[position] = skill;
                        }
                    }
                }
                else
                {
                    string[] case2 = input.Split(" vs ");

                    string playerName1 = case2[0];
                    string playerName2 = case2[1];

                    var player1 = players.FirstOrDefault(a => a.Name == playerName1);
                    var player2 = players.FirstOrDefault(a => a.Name == playerName2);

                    if (player1 != null && player2 != null)
                    {
                        foreach (var position in player1.PositionSkill)
                        {
                            foreach (var pos in player2.PositionSkill)
                            {
                                if (position.Key == pos.Key)
                                {
                                    int sumPlayer1 = player1.PositionSkill.Values.Sum();
                                    int sumPlayer2 = player2.PositionSkill.Values.Sum();

                                    if (sumPlayer1 > sumPlayer2)
                                    {
                                        check2 = true;
                                    }
                                    else if (sumPlayer2 > sumPlayer1)
                                    {
                                        check1 = true;
                                    }
                                    break;
                                }
                            }
                        }

                        if (check1)
                        {
                            players.Remove(player1);
                        }
                        else if (check2)
                        {
                            players.Remove(player2);
                        }
                    }
                }
            }

            foreach (var player in players.OrderByDescending(a => a.PositionSkill.Values.Sum()).ThenBy(n => n.Name))
            {
                Console.WriteLine($"{player.Name}: {player.PositionSkill.Values.Sum()} skill");

                foreach (var position in player.PositionSkill.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }

        public class Player
        {
            public string Name { get; set; }
            public Dictionary<string, int> PositionSkill { get; set; }

            public Player(string name, string position, int skill)
            {
                this.Name = name;
                this.PositionSkill = new Dictionary<string, int>();
                PositionSkill.Add(position, skill);
            }
        }
    }
}
