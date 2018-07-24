using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            nums.RemoveRange(arr[0], nums.Count - arr[0]);
            nums.RemoveRange(0, arr[1]);
            bool yesno = true;
            foreach (var num in nums)
            {
                if(num == arr[2])
                {
                    yesno = false;
                }
            }
            if (yesno)
            {
                Console.WriteLine("NO!");
            }
            else
            {
                Console.WriteLine("YES!");
            }
        }
    }
}
