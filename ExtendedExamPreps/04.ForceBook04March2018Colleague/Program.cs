using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ForceBook
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"(?<first>.+)(?<middle> \| | \-> )(?<second>.+)";
        var forceBook = new Dictionary<string, List<string>>();

        while (input != "Lumpawaroo")
        {
            Match tokens = Regex.Match(input, pattern);


            string delimiter = tokens.Groups["middle"].Value.Trim();
            string forceUser = "";
            string forceSide = "";


            if (delimiter == "|")
            {
                forceUser = tokens.Groups["second"].Value;
                forceSide = tokens.Groups["first"].Value;

                if (forceBook.ContainsKey(forceSide) == false)
                {
                    forceBook.Add(forceSide, new List<string>());
                }

                bool userExists = false;

                foreach (var pair in forceBook)
                {
                    if (pair.Value.Contains(forceUser))
                    {
                        userExists = true;
                    }
                }

                if (userExists == false)
                {
                    forceBook[forceSide].Add(forceUser);
                }
            }
            else if (delimiter == "->")
            {
                forceUser = tokens.Groups["first"].Value;
                forceSide = tokens.Groups["second"].Value;

                if (forceBook.ContainsKey(forceSide))
                {
                    if (forceBook[forceSide].Contains(forceUser))
                    {
                        continue;
                    }
                }

                foreach (var record in forceBook)
                {
                    if (record.Value.Contains(forceUser))
                    {
                        record.Value.Remove(forceUser);
                    }
                }

                if (forceBook.ContainsKey(forceSide) == false)
                {
                    forceBook.Add(forceSide, new List<string>());
                }

                forceBook[forceSide].Add(forceUser);
                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            }

            input = Console.ReadLine();
        }

        foreach (var record in forceBook.Where(f => f.Value.Count > 0).OrderByDescending(f => f.Value.Count).ThenBy(f => f.Key))
        {
            Console.WriteLine($"Side: {record.Key}, Members: {record.Value.Count}");

            foreach (string user in record.Value.OrderBy(u => u))
            {
                Console.WriteLine($"! {user}");
            }
        }
    }
}