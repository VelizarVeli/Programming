using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = nums[i] + nums[i + 1];
                    nums.Remove(nums[i + 1]);
                    i--;
                    if (i > 0)
                    {
                        if (nums[i] == nums[i + 1])
                        {
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
