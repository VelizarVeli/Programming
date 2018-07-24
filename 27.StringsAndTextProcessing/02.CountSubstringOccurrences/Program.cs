using System;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int index = input.IndexOf(pattern);
            int counter = 0;

            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
