using System;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            const int tank = 255;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int pouring = int.Parse(Console.ReadLine());
                sum += pouring;
                if(sum > tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= pouring;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
