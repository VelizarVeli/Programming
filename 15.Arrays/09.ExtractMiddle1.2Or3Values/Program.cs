using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddle1._2Or3Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
            }
            else if (array.Length % 2 == 0)
            {
                int middle1 = array[array.Length / 2 - 1];
                int middle2 = array[array.Length / 2];
                Console.WriteLine($"{{ {middle1}, {middle2} }}");
            }
            else
            {
                int middle1 = array[array.Length / 2 - 1];
                int middle2 = array[array.Length / 2];
                int middle3 = array[array.Length / 2 + 1];
                Console.WriteLine($"{{ {middle1}, {middle2}, {middle3} }}");
            }
        }

    }
}
