using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._0.PokemonEvolutionAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<KeyValuePair<string, int>>> data = new Dictionary<string, List<KeyValuePair<string, int>>>();
            while (input != "wubbalubbadubdub")
            {
                string[] inputs = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputs.Length == 1)
                {
                    string pokemonName = inputs[0];

                    if (data.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evolutions in data[pokemonName])
                        {
                            string type = evolutions.Key;
                            long index = evolutions.Value;
                            Console.WriteLine($"{type} <-> {index}");
                        }
                    }
                }
                else
                {
                    string pokemonName = inputs[0];

                    string evolutionType = inputs[1];
                    int evolutionIndex = int.Parse(inputs[2]);
                    if (!data.ContainsKey(pokemonName))
                    {
                        data.Add(pokemonName, new List<KeyValuePair<string, int>>());
                        KeyValuePair<string, int> evTypeInd = new KeyValuePair<string, int>(evolutionType, evolutionIndex);
                        data[pokemonName].Add(evTypeInd);
                    }
                    else
                    {
                        KeyValuePair<string, int> evTypeInd = new KeyValuePair<string, int>(evolutionType, evolutionIndex);
                        data[pokemonName].Add(evTypeInd);
                    }
                }
                input = Console.ReadLine();

            }
            foreach (var name in data)
            {
                string nam = name.Key;
                var evolutions = name.Value;
                Console.WriteLine($"# {nam}");
                foreach (var evolution in evolutions.OrderByDescending(x => x.Value))
                {
                    string type = evolution.Key;
                    long ind = evolution.Value;
                    Console.WriteLine($"{type} <-> {ind}");
                }
            }
        }
    }
}
