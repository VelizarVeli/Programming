using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
           
            for (int i = 0; i < nums.Count; i++)
            {
                {
                    string input = nums[i];
                    char[] inputarray = input.ToCharArray();
                    Array.Reverse(inputarray);
                    string output = new string(inputarray);
                    sum += int.Parse(output);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
