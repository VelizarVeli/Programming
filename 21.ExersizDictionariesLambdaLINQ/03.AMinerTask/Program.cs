using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> stones = new Dictionary<string, int>();
            while (input != "stop")
            {
                string currentOre = input;
                input = Console.ReadLine();
                if (!stones.ContainsKey(currentOre))
                {
                    stones.Add(currentOre, 0);
                }
                stones[currentOre] += int.Parse(input);
                input = Console.ReadLine();
            }
            foreach (var ore in stones)
            {
                Console.WriteLine($"{ore.Key} -> {ore.Value}");
            }
        }
    }
}
