using System;
using System.Linq;

namespace ReadingArraysFromASingleLine._2
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            string[] items = inputLine.Split(' ');
            int[] array = items.Select(int.Parse).ToArray();
        }
    }
}
