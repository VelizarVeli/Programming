using System;

namespace _03.PrintingTriangles
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n - 1; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, n);
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
