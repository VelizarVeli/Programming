using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingArraysFromASingleLine._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            int[] array = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                array[i] = int.Parse(items[i]);
            }
        }
    }
}
