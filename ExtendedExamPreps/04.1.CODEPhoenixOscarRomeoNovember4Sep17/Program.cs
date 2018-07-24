using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _04._1.CODEPhoenixOscarRomeoNovember4Sep17
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();
            string input = Console.ReadLine();
            string pattern = " -> ";
            while (input != "Blaze it!")
            {
                string[] cretureSquadmate = Regex.Split(input, pattern);
                string creature = cretureSquadmate[0];
                string squadMate = cretureSquadmate[1];
                if (squadMate == creature)
                {
                    goto End;
                }
                if (!data.ContainsKey(creature))
                {
                    data.Add(creature, new HashSet<string>());
                }
                data[creature].Add(squadMate);
                End:
                input = Console.ReadLine();
            }
            var result = new Dictionary<string, List<string>>();

            foreach (var item in data)
            {
                result.Add(item.Key, new List<string>());

                foreach (var mate in item.Value)
                {
                    if (data.ContainsKey(mate) && data[mate].Contains(item.Key))
                    {
                        continue;
                    }

                    else
                    {
                        result[item.Key].Add(mate);
                    }
                }
            }
            foreach (var item in result.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
