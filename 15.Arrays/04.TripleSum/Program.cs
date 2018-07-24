using System;
using System.Linq;

namespace _04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool counter = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        counter = false;
                    }
                }
            }
            if(counter)
            {
                Console.WriteLine("No");
            }
        }
    }
}
