using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            sbyte num = sbyte.Parse(Console.ReadLine());
            for (int l = 0; l < num; l++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "Reverse")
                {
                    Reverse(array);
                }
                else if (input[0] == "Distinct")
                {
                    string[] q = array.Distinct().ToArray();
                    array = q;
                }
                else
                {
                    int index = int.Parse(input[1]);
                    array[index] = input[2];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write($"{array[i]}");
                }
                else
                    Console.Write($"{array[i]}, ");
            }
        }

        static void Reverse(string[] array)
        {
            Array.Reverse(array);
        }
    }
}
