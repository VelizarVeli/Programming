using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!data.ContainsKey(continent))
                {
                    data.Add(continent, new Dictionary<string, List<string>>());
                    data[continent].Add(country, new List<string>());
                    data[continent][country].Add(city);
                }
                else if (!data[continent].ContainsKey(country))
                {
                    data[continent].Add(country, new List<string>());
                    data[continent][country].Add(city);
                }
                else if(!data[continent][country].Contains(city))
                {
                    data[continent][country].Add(city);
                }
            }
            foreach (KeyValuePair<string,Dictionary<string,List<string>>> continent in data)
            {
                string continen = continent.Key;
                Console.WriteLine($"{continen}:");
                foreach (KeyValuePair<string,List<string>> countr in data[continen])
                {
                    Console.WriteLine($"{countr.Key} -> {string.Join(", ",countr.Value)}");
                }
            }
        }
    }
}
