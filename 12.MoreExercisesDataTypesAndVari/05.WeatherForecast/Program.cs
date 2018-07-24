using System;
using System.Numerics;

namespace _05.WeatherForecast
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                BigInteger numb = BigInteger.Parse(input);

                if (numb >= sbyte.MinValue && numb <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (numb >= int.MinValue && numb <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (numb >= long.MinValue && numb <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Rainy");
            }
            
        }
    }
}
