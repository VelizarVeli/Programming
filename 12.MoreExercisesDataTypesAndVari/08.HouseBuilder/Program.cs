using System;

namespace _08.HouseBuilder
{
    class Program
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            long integer = Math.Max(num1, num2);
            long sbyt = Math.Min(num1, num2);

            integer *= 10;
            sbyt *= 4;

            long sum = integer + sbyt;
            Console.WriteLine(sum);
        }
    }
}
