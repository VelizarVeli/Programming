using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int count = -1;

            for (int j = 0; j < arr.Length; j++)
            {
                int leftSum = 0;
                for (int left = 0; left < j; left++)
                {
                    leftSum += arr[left];
                }
                int rightSum = 0;
                for (int right = arr.Length - 1; right > j; right--)
                {
                    rightSum += arr[right];
                }
                if (leftSum == rightSum)
                {
                    count = j;
                }
            }
            if (count == -1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(count);
            }
        }
    }
}
