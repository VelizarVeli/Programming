using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            double sum = input.Sum();
            int min = input.Min();
            int max = input.Max();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {input.Average()}");

        }
    }
}
