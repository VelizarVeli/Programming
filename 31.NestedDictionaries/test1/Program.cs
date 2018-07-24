using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
      { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13 };
            int dividor = 5;

            var numberGroups =
                  from number in numbers
                  group number by number % divisor into group
                  select new { Remainder = group.Key, Numbers = group };

            foreach (var group in numberGroups)
            {
                Console.WriteLine(
                "Numbers with a remainder of {0} when divided by {1}:",
                      group.Remainder, divisor);
                foreach (var number in group.Numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
