using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList<string>();
            SortedDictionary<string, Dictionary<string, int>> inputDictionary = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string tempUser = input[2];
                string user = tempUser.Substring(5);
                string tempIP = input[0];
                string IP = tempIP.Substring(3);
                int counter = 1;
                if (!inputDictionary.ContainsKey(user))
                {
                    inputDictionary.Add(user, new Dictionary<string, int>());
                }
                if (!inputDictionary[user].ContainsKey(IP))
                {
                    inputDictionary[user].Add(IP, counter);
                }
                else
                {
                    inputDictionary[user][IP]++;
                }
                input = Console.ReadLine().Split(' ').ToList<string>();
            }
            foreach (var user in inputDictionary)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var log in user.Value)
                {
                    var thing = log.Key;
                    if (log.Key != user.Value.Keys.Last()) Console.Write($"{log.Key} => {log.Value}, ");
                    else Console.WriteLine($"{log.Key} => {log.Value}.");
                }
            }
        }
    }
}
