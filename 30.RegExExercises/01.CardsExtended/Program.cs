using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"([1]?[0-9AJKQ])([SHDC])";
            //matches 1 between zero and one times, as many times as possible, giving back as needed, then continues matching the power
            //and suit

            var input = Console.ReadLine();
            var regex = new Regex(pattern);
            var cards = new List<Match>();
            var validCards = regex.Matches(input);

            foreach (Match match in validCards)
            {
                var power = 0;

                if (int.TryParse(match.Groups[1].Value, out power)) //see if the card is between 2-10
                {
                    if (power < 2 || power > 10) //if the power is not valid, continue
                    {
                        continue;
                    }
                }
                cards.Add(match); //add the matches(cards) to the list
            }
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}