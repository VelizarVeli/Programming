using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (array.Length > 1)
            {
                int[] arr2 = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    int sum = array[i] + array[i + 1];
                    arr2[i] = sum;
                }
                array = arr2;
            }
            Console.WriteLine(array[0]);
        }
    }
}
