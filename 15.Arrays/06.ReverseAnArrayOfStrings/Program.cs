using System;
using System.Linq;

namespace _06.ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').Reverse().ToArray();
            
            for (int i = 0; i < array.Length; i++)
            {
            Console.Write($"{array[i]} ");
            }
        }
    }
}
