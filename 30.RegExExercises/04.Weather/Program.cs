using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<city>[A-Z]{2})(?<temperature>[0-9]{1,2}\.[0-9]{1,2})(?<weather>[A-Za-z]+)\|";
            var input = Console.ReadLine();
            Dictionary<string, SortedDictionary<float, string>> weatherCast = new Dictionary<string, SortedDictionary<float, string>>();
            while (input != "end")
            {
                var matched = Regex.Match(input, pattern);
                bool matching = Regex.IsMatch(input, pattern);
                if (matching)
                {
                    string city = matched.Groups["city"].Value;
                    float temperature = float.Parse(matched.Groups["temperature"].Value);
                    string weather = matched.Groups["weather"].Value;
                    if (!weatherCast.ContainsKey(city))
                    {
                        SortedDictionary<float, string> weaTemp = new SortedDictionary<float, string>();
                        weaTemp.Add(temperature, weather);
                        weatherCast.Add(city, weaTemp);
                    }
                    else
                    {
                        weatherCast.Remove(city);
                        weatherCast.Add(city, new SortedDictionary<float, string>());
                        weatherCast[city][temperature] = weather;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var city in weatherCast.OrderBy(x => x.Value.Keys.Min()))
            {
                foreach (var temperatur in city.Value)
                {
                    string city1 = city.Key;
                    float tempe = temperatur.Key;
                    string weath = temperatur.Value;
                    Console.WriteLine($"{city1} => {tempe:f2} => {weath}");
                }

            }

        }
    }
}