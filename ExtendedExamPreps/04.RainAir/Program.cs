using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// решена за 1 час и 13 минути 70/100
namespace _04.RainAir
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "I believe I can fly!")
            {
                string[] customerData = input.Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                string name = customerData[0];
                try
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<int>());
                    }
                    for (int i = 1; i < customerData.Length; i++)
                    {
                        int flightNumber = int.Parse(customerData[i]);
                        data[name].Add(flightNumber);
                    }
                }
                catch (Exception)
                {
                    string secondName = customerData[1];
                    data[name] = data[secondName];
                }
                input = Console.ReadLine();
            }
            foreach (var customer in data.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
            {
                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ", customer.Value.OrderBy(a => a))}");
            }
        }
    }
}
