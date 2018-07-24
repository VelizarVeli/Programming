using System;

// решена втори път за време 33 минути 100/100
namespace _01._1.Again
{
    class Program
    {
        static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            decimal distanceFor1000WingFlaps = decimal.Parse(Console.ReadLine());   
            long endurance = long.Parse(Console.ReadLine());

            decimal metersTravelled = (wingFlaps / 1000) * distanceFor1000WingFlaps;
            decimal flapsPerSec = wingFlaps / 100;
            decimal secondsPast = (wingFlaps / endurance) * 5 + flapsPerSec;

            Console.WriteLine($"{metersTravelled:f2} m.");
            Console.WriteLine($"{secondsPast} s.");
        }
    }
}
