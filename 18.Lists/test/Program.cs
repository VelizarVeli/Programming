using System;
using System.Linq;
using System.Collections.Generic;



namespace CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counts = new int[nums.Max() + 1];
            foreach (var num in nums)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if(counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}
