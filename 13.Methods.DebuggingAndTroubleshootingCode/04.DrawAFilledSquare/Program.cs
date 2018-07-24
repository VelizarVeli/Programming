using System;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void PrintDashes(int dashes)
        {
            Console.WriteLine(new string('-', 2 * dashes));
        }
        static void PrintMiddleRows(int slashes)
        {
            Console.Write("-");
            for (int i = 1; i < slashes; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintDashes(n);
            
                for (int i = 0; i < n - 2; i++)
                {
                    PrintMiddleRows(n);
                }
           
            PrintDashes(n);
        }
    }
}
