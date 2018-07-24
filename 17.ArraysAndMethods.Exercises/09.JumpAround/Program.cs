using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long sum = 0L;
            int index = 0;
            while (index >= 0 && index <= array.Length)
            {
                int tempIndex = index;
                sum += array[tempIndex];
                index += array[tempIndex];
                if (index >= array.Length)
                {
                    index = tempIndex - array[tempIndex];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
