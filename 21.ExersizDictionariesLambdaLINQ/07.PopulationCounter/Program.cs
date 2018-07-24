using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);
                Dictionary<string, long> cityPopulation = new Dictionary<string, long>();

                if (!populations.ContainsKey(country))
                {
                    cityPopulation[city] = population;
                    populations.Add(country, cityPopulation);
                }
                else
                {
                    cityPopulation = populations[country];
                    if (cityPopulation.ContainsKey(city))
                    {
                        cityPopulation[city] += population;
                    }
                    else
                    {
                        cityPopulation.Add(city, population);
                        populations[country] = cityPopulation;
                    }
                }
                input = Console.ReadLine().Split('|').ToArray();
            }
            foreach (var state in populations.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}
