using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            int entryCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < entryCount; i++)
            {
                string[] entryArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string ip = entryArgs[0];
                string userName = entryArgs[1];
                int duration = int.Parse(entryArgs[2]);

                InsertUserName(userLogs, userName);
                InsertIpAndDuration(userLogs, userName, ip, duration);
            }
                PrintUSerLogs(userLogs);

            //int lines = int.Parse(Console.ReadLine());
            //SortedDictionary<string, Dictionary<List<string>,int>> logsAggregator = new SortedDictionary<string, Dictionary<List<string>,int>>();
            //for (int i = 0; i < lines; i++)
            //{
            //    string[] input = Console.ReadLine().Split(' ').ToArray();
            //    string IP = input[0];
            //    string user = input[1];
            //    int duration = int.Parse(input[2]);
            //    Dictionary<int, List<string>> durationAndIPs = new Dictionary<int, List<string>>();
            //    List<string> IPs = new List<string>();

            //    if (!logsAggregator.ContainsKey(user))
            //    {
            //        IPs.Add(IP);
            //        durationAndIPs[duration] = IPs;
            //        logsAggregator[user] = durationAndIPs;
            //    }
            //    else
            //    {
            //        IPs.Add(IP);
            //        durationAndIPs[duration] += duration = IPs;
            //    }
            //}
        }

        private static void PrintUSerLogs(SortedDictionary<string, SortedDictionary<string, int>> userLogs)
        {
            foreach (var userEntry in userLogs)
            {
                string userName = userEntry.Key;
                int durationTotal = userEntry.Value.Values.Sum();
                List<string> userIps = userEntry.Value.Keys.ToList();

                Console.WriteLine($"{userName}: {durationTotal} [{string.Join(", ", userIps)}]");
            }
        }

        private static void InsertIpAndDuration(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName, string ip, int duration)
        {
            if (!userLogs[userName].ContainsKey(ip))
            {
                userLogs[userName].Add(ip, 0);
            }
            userLogs[userName][ip] += duration;
        }

        private static void InsertUserName(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName)
        {
            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new SortedDictionary<string, int>());
            }
        }
    }
}
