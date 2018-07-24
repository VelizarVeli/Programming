using System;

namespace _02.ReverseArrayOfIntegers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
                Console.WriteLine();
        }
    }
}
