using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            long sum = 0L;
            while (true)
            {
                int tempIndex = index;
                sum += numbers[index];
                index += numbers[index];
                if (index >= numbers.Length)
                {
                    index = tempIndex - numbers[tempIndex];
                    if (index < 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
