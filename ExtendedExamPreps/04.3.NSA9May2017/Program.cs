using System;
using System.Collections.Generic;
using System.Linq;
//решена за 28 минути 100/100
namespace _04._3.NSA9May2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            while (input[0] != "quit")
            {
                string country = input[0];
                string spy = input[1];
                long daysInService = long.Parse(input[2]);

                if (!data.ContainsKey(country))
                {
                    data.Add(country,new Dictionary<string, long>());
                }
                if (!data[country].ContainsKey(spy))
                {
                    data[country].Add(spy,daysInService);
                }
                data[country][spy]= daysInService;

                input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var country1 in data.OrderByDescending(a => a.Value.Count))
            {
                string chec = country1.Key;
                Dictionary<string, long> che = country1.Value;
                Console.WriteLine($"Country: {chec}");
                foreach (var count in che.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"**{count.Key} : {count.Value}");
                }
            }
        }
    }
}
