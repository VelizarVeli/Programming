using System;
using System.Linq;

namespace ReadingArraysFromASingleLine._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
