using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();
            while (input[0] != "filter")
            {
                string name = input[0];
                string[] topics = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                if (!data.ContainsKey(name))
                {
                    data.Add(name, new HashSet<string>());
                }
                foreach (var topic in topics)
                {
                    data[name].Add(topic);
                }
                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            string[] checWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (KeyValuePair<string, HashSet<string>> topic in data)
            {
                string nam = topic.Key;
                HashSet<string> top = topic.Value;
                int counter = 0;
                for (int i = 0; i < checWords.Length; i++)
                {
                    string check = checWords[i];
                    if (top.Contains(check))
                    {
                        counter++;
                    }
                }
                if (counter == checWords.Length)
                {
                    Console.WriteLine($"{nam} | #{string.Join(", #", top)}");
                }
            }
        }
    }
}
