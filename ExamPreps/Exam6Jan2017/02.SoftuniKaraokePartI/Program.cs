using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftuniKaraokePartI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var availableSongs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(',').ToArray();
            bool check = true;
            while (input[0] != "dawn")
            {
                string name = input[0].Trim();
                string song = input[1].Trim();
                string award = input[2].Trim();
                if (availableSongs.Contains(song) && participants.Contains(name))
                {

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<string>());
                    }
                    if (!data[name].Contains(award))
                    {
                        check = false;
                        data[name].Add(award);
                    }

                }

                input = Console.ReadLine().Split(',').ToArray();
            }
            if (check)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (KeyValuePair<string, List<string>> pair in data
                    .OrderByDescending(a => a.Value.ToList().Count)
                    .ThenBy(n => n.Key))
                {

                    List<string> awards = pair.Value.ToList();
                    Console.WriteLine($"{pair.Key}: {awards.Count} awards");
                    foreach (string award in awards.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
