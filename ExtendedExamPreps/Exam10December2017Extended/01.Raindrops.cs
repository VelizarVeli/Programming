using System;
using System.Linq;
//решена за 24 минути 100/100

namespace Raindrops
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < N; i++)
            {
                decimal[] regionalCoefficients = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
                decimal raindropsCount = regionalCoefficients[0];
                decimal squareMeters = regionalCoefficients[1];
                decimal coefficient = raindropsCount / squareMeters;
                sum += coefficient;
            }
            try
            {
                Console.WriteLine($"{sum / density:f3}");
            }
            catch (Exception)
            {
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
