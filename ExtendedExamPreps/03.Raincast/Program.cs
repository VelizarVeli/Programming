using System;
using System.Linq;
using System.Text.RegularExpressions;
// решена за 1 час и 20 минути 60/100
namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool type = false;
            string type1 = String.Empty;
            bool forecast = false;
            string forecast1 = String.Empty;
            bool source = false;
            string source1 = String.Empty;
            while (input != "Davai Emo")
            {
                if ((input == "Type: Normal" || input == "Type: Warning" || input == "Type: Danger") && type == false)
                {
                    type = true;
                    string type2 = input.Substring(6);
                    type1 = type2;
                    goto End;
                }
                string pattern = @"\bSource: \b[\w\d]+";
                Match regex = Regex.Match(input, pattern);
                if (type && regex.Success)
                {
                    source = true;
                    source1 = input.Substring(8);
                }
                string[] subby1 = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string subby2 = subby1[0];
                if (subby2 == "Forecast:")
                {
                    string subby = input.Substring(input.IndexOf(' ') + 1);
                    if (type && source && (!subby.Contains('!') && !subby.Contains(',') && !subby.Contains('.') && !subby.Contains('?')))
                    {
                        forecast = true;
                        forecast1 = input.Substring(10);
                    }
                }

                if (type && source && forecast)
                {
                    Console.WriteLine($"({type1}) {forecast1} ~ {source1}");
                    type = false;
                    forecast = false;
                    source = false;
                    type1 = String.Empty;
                    forecast1 = String.Empty;
                    source1 = String.Empty;
                }
                End:
                input = Console.ReadLine();
            }
        }
    }
}
