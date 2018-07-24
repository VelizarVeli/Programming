using System;
using System.Linq;
// решена за време 27 минути 100/100 

namespace _02._8._12June2016
{
    class Program
    {
        static void Main()
        {
            decimal[] data = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var aver = data.Average();
            var first5 = data.OrderByDescending(i => i).Where(r => r > aver).Take(5).ToArray();
            if (first5.Length == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", first5));
            }
        }
    }
}
