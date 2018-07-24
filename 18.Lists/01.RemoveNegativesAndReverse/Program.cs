using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var positiveInts = nums.Where(i => i >= 0);
            nums.RemoveAll(i => i < 0);
            nums.Reverse();
            int sum = nums.Sum();
            if (sum == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var item in nums)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
