using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//  70/100 за 2 часа
namespace _03._2._6January2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"[@|#|\$|\^]";
            Regex regex = new Regex(pattern);
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (regex.IsMatch(ticket))
                {
                    MatchCollection matches = Regex.Matches(ticket, pattern);
                    if (matches.Count == 20)
                    {
                        if (ticket.Contains("@"))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10@ Jackpot!");
                        }
                        else if (ticket.Contains("#"))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10# Jackpot!");
                        }
                        else if (ticket.Contains("^"))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10^ Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10$ Jackpot!");
                        }
                    }
                    else if (matches.Count > 11 && matches.Count <= 18 && matches.Count % 2 == 0)
                    {
                        if (ticket.Contains("@"))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matches.Count / 2}@");
                        }
                        else if (ticket.Contains("#"))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matches.Count / 2}#");
                        }
                        else if (ticket.Contains("^"))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matches.Count / 2}^");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matches.Count / 2}$");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
