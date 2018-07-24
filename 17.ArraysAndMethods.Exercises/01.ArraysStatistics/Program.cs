using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArraysStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            double sum = 0;
            double average = 0.0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
                sum += array[i];
                average = sum / array.Length;
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");            
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
