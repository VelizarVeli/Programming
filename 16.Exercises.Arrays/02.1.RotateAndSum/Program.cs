using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1.RotateAndSum
{
    class Program
    {

        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotationsCount = int.Parse(Console.ReadLine());

            var sumArray = new int[arr.Length];

            for (int i = 0; i < rotationsCount; i++)
            {
                RotateArray(arr);

                for (int j = 0; j < arr.Length; j++)
                {
                    sumArray[j] += arr[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static void RotateArray(int[] arr)
        {
            var lastElement = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;
        }
    }
}
