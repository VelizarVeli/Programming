using System;
using System.Collections.Generic;

namespace _07._1.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> townsSales = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Sale obj = ReadSale(input);
                if (!townsSales.ContainsKey(obj.Town))
                {
                    townsSales.Add(obj.Town, obj.Price * obj.Quantity);
                }
                else
                {
                    townsSales[obj.Town] += obj.Price * obj.Quantity;
                }
            }

            foreach (var town in townsSales)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        private static Sale ReadSale(string input)
        {
            string[] input1 = input.Split();
            Sale currentSale = new Sale();

            currentSale.Town = input1[0];
            currentSale.Product = input1[1];
            currentSale.Price = decimal.Parse(input1[2]);
            currentSale.Quantity = decimal.Parse(input1[3]);
            return currentSale;
        }

        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }
    }
}
