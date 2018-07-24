using System;

namespace _02.CircleArea_12DigitsPrecision_
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(Math.PI * r * r):f12}");
        }
    }
}
