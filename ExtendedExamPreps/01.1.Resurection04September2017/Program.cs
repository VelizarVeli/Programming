using System;
//решена за 12 минути 100/100
namespace _01._1.Resurection04September2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                long length = long.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                int wingLength1 = int.Parse(Console.ReadLine());
                decimal years = length * length * (width + 2 * wingLength1);
                Console.WriteLine(years);
            }
        }
    }
}
