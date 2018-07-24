using System;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            
            do
            {
                Console.WriteLine($"{n} X {m} = {n * m}");
                m++;
                if (m > 10)
                {
                    break;
                }

            } while (m < 11);
        }
    }
}
