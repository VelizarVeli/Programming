using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var dict = new SortedDictionary<double, int>();
            foreach (var num in input)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }
            foreach (var num in dict)
            {
                Console.WriteLine(num.Key + " -> " + num.Value);
            }
        }
    }
}
