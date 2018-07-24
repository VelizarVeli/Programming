using System;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int number = 0;
            int counter = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    number = number + (3 * (i * j));
                    counter++;
                    if(number >= maxSumBoundary)
                    {
                        break;
                    }
                }
                if (number >= maxSumBoundary)
                {
                    break;
                }
            }
            if (maxSumBoundary > number)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {number}");
            }
            else if (maxSumBoundary <= number)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {number} >= {maxSumBoundary}");
            }
        }
    }
}
