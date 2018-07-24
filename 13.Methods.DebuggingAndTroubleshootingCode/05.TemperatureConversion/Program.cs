using System;

namespace _05.TemperatureConversion
{
    class Program
    {
        static double ConvertToCelsius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
        static void Main()
        {
            double farenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertToCelsius(farenheit);
            Console.WriteLine($"{celsius:f2}");
        }
    }
}
