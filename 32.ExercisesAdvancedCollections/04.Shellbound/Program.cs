using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, HashSet<int>> data = new Dictionary<string, HashSet<int>>();
            while (input[0] != "Aggregate")
            {
                string place = input[0];
                int space = int.Parse(input[1]);

                if (!data.ContainsKey(place))
                {
                    data.Add(place, new HashSet<int>());
                }
                data[place].Add(space);
                input = Console.ReadLine().Split(' ').ToArray();
            }
            foreach (KeyValuePair<string, HashSet<int>> shellPlace in data)
            {
                string plac = shellPlace.Key;
                HashSet<int> spac = shellPlace.Value;
                double subtractAver = spac.Sum() - Math.Truncate(spac.Average());

                ; Console.WriteLine($"{plac} -> {string.Join(", ", spac)} ({subtractAver})");
            }
        }
    }
}
