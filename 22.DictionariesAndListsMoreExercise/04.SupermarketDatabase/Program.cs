using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, decimal[]> data = new Dictionary<string, decimal[]>();
            decimal price = decimal.Parse(input[1]);
            decimal quantity = decimal.Parse(input[2]);
            decimal[] arr = new decimal[2] { price, quantity };
            while (input[0] != "stocked")
            {
                price = decimal.Parse(input[1]);
                quantity = decimal.Parse(input[2]);
                arr = new decimal[2] { price, quantity };
                string name = input[0];

                if (!data.ContainsKey(name))
                {
                    data.Add(name, arr);
                }
                else
                {
                    arr[0] = price;
                    data[name][0] = arr[0];
                    data[name][1] += arr[1];
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
            var grandTotal = 0M;
            foreach (var name in data)
            {
                var totalPrice = name.Value[0] * name.Value[1];
                grandTotal += totalPrice;
                Console.WriteLine($"{name.Key}: ${name.Value[0]} * {name.Value[1]} = ${totalPrice}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal}");
        }
    }
}
