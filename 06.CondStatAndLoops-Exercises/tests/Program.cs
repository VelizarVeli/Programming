using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int s = 0;
            try
            {
                int num = int.Parse(Console.ReadLine());

                while (true)
                {
                    s++;
                    num = int.Parse(Console.ReadLine());

                }

            }
            catch
            {
                Console.WriteLine($"{s}");

            }

        }
    }
}