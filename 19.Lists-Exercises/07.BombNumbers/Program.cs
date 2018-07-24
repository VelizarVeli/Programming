using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bombNumber[0])
                {
                    if (bombNumber[1] + i >= nums.Count)
                    {
                        nums.RemoveRange(i, nums.Count - i);

                        if (i < bombNumber[1])
                        {
                            nums.RemoveRange(0, i);
                        }
                        else
                        {
                            nums.RemoveRange(i - bombNumber[1], bombNumber[1]);
                        }
                        i--;
                    }
                    else
                    {
                        nums.RemoveRange(i, bombNumber[1] + 1);
                        if (i < bombNumber[1])
                        {
                            nums.RemoveRange(0, i);
                        }
                        else
                        {
                            nums.RemoveRange(i - bombNumber[1], bombNumber[1]);
                        }
                        i--;

                    }
                }
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
