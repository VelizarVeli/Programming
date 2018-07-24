using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var odd = input.Where(n => n % 2 == 0).ToList();
            double average = odd.Average();
            odd = odd.Select(n => n = n > average ? ++n : --n).ToList();
            Console.WriteLine(string.Join(" ",odd));
        }
    }
}
