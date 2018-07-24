using System;
using System.Collections.Generic;
using System.Linq;
//решена за време 2 часа с подсказка 100/100
namespace _04._0.PokemonEvolutionAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<KeyValuePair<string, int>>> evolutions = new Dictionary<string, List<KeyValuePair<string, int>>>();
            while (input != "wubbalubbadubdub")
            {
                string[] inputData = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputData[0];
                if (inputData.Length == 1)
                {
                    if (evolutions.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var index in evolutions[name])
                        {
                            Console.WriteLine($"{index.Key} <-> {index.Value}");
                        }
                    }
                }
                else
                {
                    string type = inputData[1];
                    int index = int.Parse(inputData[2]);
                    if (!evolutions.ContainsKey(name))
                    {
                        evolutions.Add(name, new List<KeyValuePair<string, int>>());
                        KeyValuePair<string, int> typeIndex = new KeyValuePair<string, int>(type, index);
                        evolutions[name].Add(typeIndex);
                    }
                    else
                    {
                        KeyValuePair<string, int> typeIndex = new KeyValuePair<string, int>(type, index);
                        evolutions[name].Add(typeIndex);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var name in evolutions)
            {
                string nam = name.Key;
                var evolutio = name.Value;
                Console.WriteLine($"# {nam}");
                foreach (var evolution in evolutio.OrderByDescending(x => x.Value))
                {
                    string type = evolution.Key;
                    long ind = evolution.Value;
                    Console.WriteLine($"{type} <-> {ind}");
                }
            }
        }
    }
}
