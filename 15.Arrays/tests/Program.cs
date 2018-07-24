using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int newar = array[i] + array[i + 1];
                int[] arra2 = new int[array.Length];
                arra2[i] = newar;
                Console.Write($"{newar} ");
            }
        }
    }
}