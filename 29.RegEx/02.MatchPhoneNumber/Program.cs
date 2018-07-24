using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"[\+359]{4}( |-)[2]\1[0-9]{3}\1[0-9]{4}\b";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = Regex.Matches(phones,regex).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
