using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HornetCommRegexVenci
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageRegex = @"^([\d]+) <-> ([a-zA-Z0-9]+)";
            string broadcastRegex = @"^([\D]+) <-> ([a-zA-Z0-9]+)$";
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();
            Regex message = new Regex(messageRegex);
            Regex broadcast = new Regex(broadcastRegex);
            string input;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                var inputArgs = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (message.IsMatch(input))
                {
                    messages.Add($"{string.Join("", inputArgs[0].ToCharArray().Reverse())} -> {inputArgs[1]}");
                }
                if (broadcast.IsMatch(input))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in inputArgs[1].ToCharArray())
                    {
                        if (Char.IsLower(c))
                        {
                            sb.Append(Char.ToUpper(c));
                            continue;
                        }
                        if (Char.IsUpper(c))
                        {
                            sb.Append(Char.ToLower(c));
                            continue;
                        }
                        sb.Append(c);
                    }
                    broadcasts.Add($"{sb} -> {inputArgs[0]}");
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count != 0)
            {
                foreach (var currentBbroadcast in broadcasts)
                {
                    Console.WriteLine(currentBbroadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count !=0)
            {
                foreach (var currentMessage in messages)
                {
                    Console.WriteLine(currentMessage);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
