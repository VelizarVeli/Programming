using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double abs = Math.Abs(array[i]);
                double add = abs + 0.5;
                double trunc = Math.Truncate(add);
                if (array[i] < 0)
                {
                    Console.WriteLine($"{array[i]} => {trunc * (-1)}");
                }
                else
                {
                    Console.WriteLine($"{array[i]} => {trunc}");
                }
            }

        }
    }
}
