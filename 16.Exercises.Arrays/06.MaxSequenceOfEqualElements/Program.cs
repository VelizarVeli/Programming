using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentCount = 1;
            int numberCount = 1;
            int number = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentCount++;

                    if (currentCount > numberCount)
                    {
                        numberCount = currentCount;
                        number = arr[i];
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            for (int i = 0; i < numberCount; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}

