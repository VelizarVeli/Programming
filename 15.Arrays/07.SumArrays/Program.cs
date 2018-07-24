using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxArr = Math.Max(array1.Length, array2.Length);

            for (int i = 0; i < maxArr; i++)
            {
                int sum = array1[i % array1.Length] + array2[i % array2.Length];
                Console.Write($"{sum} ");
            }
        }
    }
}
