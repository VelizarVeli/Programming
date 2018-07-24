using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//за 1 час 80/100 

namespace _03._8.WinningTicketAgain
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"[\^]{6,}|[\@]{6,}|[#]{6,}|[$]{6,}";

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftSide = ticket.Substring(0, 10);
                    string rightSide = ticket.Substring(10, 10);
                    Match left = Regex.Match(leftSide, pattern);
                    Match right = Regex.Match(rightSide, pattern);
                    string right1 = right.ToString();
                    string left1 = left.ToString();
                    if (left1 == right1 && left1.Length >= 6 && left1.Length <= 9)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {left1.Length}{left1[0]}");
                    }
                    else if (left1 == right1 && left1.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {left1.Length}{left1[0]} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
