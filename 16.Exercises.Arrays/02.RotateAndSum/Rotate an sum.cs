using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            bool check = true;
            for (int i = 1; i <= r; i++)
            {
                int[] array2 = new int[array.Length];
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == 0)
                    {
                        array2[0] = array[array.Length - 1];
                    }
                    else
                    {
                        array2[j] = array[j - 1];
                    }
                    sum[j] = array2[j] + sum[j];
                    check = false;
                }
                array = array2;
            }
            if (check)
            {
                sum = array;
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
        }
    }
}
