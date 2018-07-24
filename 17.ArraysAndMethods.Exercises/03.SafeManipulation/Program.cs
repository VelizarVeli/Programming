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
            string[] input = Console.ReadLine().Split(' ').ToArray();
            do
            {

                if (input[0] == "Reverse")
                {
                    Reverse(array);
                }
                else if (input[0] == "Distinct")
                {
                    string[] q = array.Distinct().ToArray();
                    array = q;
                }
                else if (input[0] == "Replace")
                {
                    int index = int.Parse(input[1]);
                    if (index >= array.Length || index < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        array[index] = input[2];
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            while (input[0] != "END");

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
