using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long num = long.Parse(Console.ReadLine());
            long sum = 0;
            bool check = true;

            for (long i = array.Length - 1; i >= 0; i--)
            {
                if(array[i] == num)
                {
                    for (long j = 0; j < i; j++)
                    {
                        sum += array[j];
                    }
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
            Console.WriteLine(sum);
            }
        }
    }
}
