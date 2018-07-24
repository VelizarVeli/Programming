using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//решена за време използвайки регекси за 2 часа
namespace _03._7._26February2017
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string privateMessage = @"(^[\d]+)( <-> )([\w|\d]+)$";
            string broadcast = @"^([\D]+)( <-> )([\w|\d]+)$";

            List<KeyValuePair<string, string>> allPrivateMessages = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> allBroadcasts = new List<KeyValuePair<string, string>>();

            while (input != "Hornet is Green")
            {
                MatchCollection splitPrivateMessage = Regex.Matches(input, privateMessage);
                MatchCollection splitBroadcast = Regex.Matches(input, broadcast);

                foreach (Match m in splitPrivateMessage)
                {
                    string value1 = m.Groups[2].Value;
                    string[] privateMessages = Regex.Split(input, value1);
                    string ReversedRecipientCode = Reverse(privateMessages[0]);
                    string message = privateMessages[1];

                    var kvp = new KeyValuePair<string, string>(ReversedRecipientCode, message);
                    allPrivateMessages.Add(kvp);
                }
                foreach (Match m in splitBroadcast)
                {
                    string value1 = m.Groups[2].Value;
                    string[] broadcasts = Regex.Split(input, value1);
                    string frequency = CapitaltoLowerAndViceVersa(broadcasts[1]);
                    string message = broadcasts[0];
                    var kvp = new KeyValuePair<string, string>(frequency, message);
                    allBroadcasts.Add(kvp);
                }

                input = Console.ReadLine();
            }
            if (allBroadcasts.Count == 0)
            {
                Console.WriteLine("Broadcasts:");

                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Broadcasts:");
                foreach (var broadcasting in allBroadcasts)
                {
                    Console.WriteLine($"{broadcasting.Key} -> {broadcasting.Value}");
                }
            }
            
            if (allPrivateMessages.Count == 0)
            {
                Console.WriteLine("Messages:");

                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Messages:");
                foreach (var message in allPrivateMessages)
                {
                    Console.WriteLine($"{message.Key} -> {message.Value}");
                }
            }
            
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string CapitaltoLowerAndViceVersa(string message)
        {
            var messageChar = message.ToCharArray();
            for (int i = 0; i < messageChar.Length; i++)
            {
                if (Char.IsLower(messageChar[i]))
                {
                    messageChar[i] = char.ToUpper(messageChar[i]);
                }
                else if (Char.IsUpper(messageChar[i]))
                {
                    messageChar[i] = char.ToLower(messageChar[i]);
                }
            }
            string message1 = new string(messageChar);
            
            return message1;
        }
    }
}
