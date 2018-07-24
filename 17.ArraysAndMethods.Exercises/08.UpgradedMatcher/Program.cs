using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string[]input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "done")
            {
                int check = Array.IndexOf(products, input[0]);
                long quantity = long.Parse(input[1]);
                if (check >= quantities.Length || quantities[check] < quantity)
                {
                    Console.WriteLine($"We do not have enough {products[check]}");
                }
                else
                {
                    decimal totalPrice = prices[check] * quantity;
                    Console.WriteLine($"{products[check]} x {quantity} costs {totalPrice:f2}");
                    quantities[check] -= quantity;
                }
                    input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
