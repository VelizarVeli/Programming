using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> currentSeq = new List<int>();
            List<int> maxSeq = new List<int>();
            int currentCount = 0;
            int maxCount = 0;

            for (int i = nums.Length - 1; i >= 1; i--)
            {
                if (nums[i] == nums[i - 1])
                {
                    currentSeq.Add(nums[i]);
                    if (currentCount == 0)
                    {
                        currentSeq.Add(nums[i - 1]);
                    }
                    currentCount++;
                }
                else
                {
                    currentCount = 0;
                    currentSeq = new List<int>();
                }
                if (maxCount <= currentCount)
                {
                    maxCount = currentCount;
                    maxSeq = currentSeq;
                }
            }
            if (maxCount > 0)
            {
                Console.WriteLine(string.Join(" ", maxSeq));
            }
            else
            {
                Console.WriteLine(nums[0]);
            }
        }
    }
}
