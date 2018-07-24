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
            string input = Console.ReadLine();
            do
            {
                int check = Array.IndexOf(products, input);
                Console.WriteLine($"{products[check]} costs: {prices[check]}; Available quantity: {quantities[check]}");
                input = Console.ReadLine();
            } while (input != "done");
        }
    }
}