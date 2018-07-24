using System;
using System.Collections.Generic;
using System.Linq;
namespace Pb4ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var sidesAndUsers = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                else if (input.Contains("|"))
                {
                    string[] inputLine = input.Split("|");
                    string side = inputLine[0].Trim();
                    string user = inputLine[1].Trim();
                    if (!sidesAndUsers.ContainsKey(side))
                    {
                        sidesAndUsers[side] = new List<string>();
                        if (!sidesAndUsers.Values.Any(x => x.Contains(user)))
                        {
                            sidesAndUsers[side].Add(user);
                        }
                    }
                    else if (!sidesAndUsers.Values.Any(x => x.Contains(user)))
                    {
                        sidesAndUsers[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] inputLine = input.Split("->");
                    string side = inputLine[1].Trim();
                    string user = inputLine[0].Trim();
                    if (!sidesAndUsers.ContainsKey(side))
                    {
                        sidesAndUsers[side] = new List<string>();
                        if (!sidesAndUsers.Values.Any(x => x.Contains(user)))
                        {
                            sidesAndUsers[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                    else if (!sidesAndUsers.Values.Any(x => x.Contains(user)))
                    {
                        sidesAndUsers[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var userSide in sidesAndUsers)
                        {
                            if (userSide.Value.Contains(user))
                            {
                                userSide.Value.Remove(user);
                                sidesAndUsers[side].Add(user);
                                Console.WriteLine($"{user} joins the {side} side!");
                                break;
                            }
                        }
                    }
                }
            }
            foreach (var forceSide in sidesAndUsers.OrderByDescending(count => count.Value.Count).ThenBy(nameSide => nameSide.Key))
            {
                if (forceSide.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");
                    foreach (var user in forceSide.Value.OrderBy(name => name))
                    {
                        Console.WriteLine("! " + user);
                    }
                }
            }
        }
    }
}