using System;

namespace _17.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
