using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b[\d]{2}(\.|-|\/)[A-S]{1}[a-z]{2}\1[\d]{4}\b";

            var tring = Console.ReadLine();
            var dateString = Regex.Matches(tring, regex).Cast<Match>().Select(a => a.Value).ToArray();

            foreach (var date in dateString)
            {
                var splitDate = date.Split('/', '.', '-').ToArray();
                Console.WriteLine($"Day: {splitDate[0]}, Month: {splitDate[1]}, Year: {splitDate[2]}");
            }
            //Console.WriteLine(string.Join(", ",dateString));
        }
    }
}
