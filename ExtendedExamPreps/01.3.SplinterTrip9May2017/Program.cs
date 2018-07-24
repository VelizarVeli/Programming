using System;
// решена за 25 минути 100/100
namespace _01._3.SplinterTrip9May2017
{
    class Program
    {
        static void Main()
        {
            double tripDistanceInMiles = double.Parse(Console.ReadLine());
            double fuelTankCapacitiyInLiters = double.Parse(Console.ReadLine());
            double milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDistanceInMiles - milesSpentInHeavyWinds;
            double nonHeavyWindsConsupmtion = milesInNonHeavyWinds * 25;
            double heavyWindsConsumtion = milesSpentInHeavyWinds * (25 * 1.5);
            double fuelConsumption = nonHeavyWindsConsupmtion + heavyWindsConsumtion;
            double tolerance = fuelConsumption * 0.05;
            double totalFuelConsumption = fuelConsumption + tolerance;
            double remainingFuel = fuelTankCapacitiyInLiters - totalFuelConsumption;
            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
            if (remainingFuel >= 0)
            {
                Console.WriteLine($"Enough with {Math.Round(remainingFuel,3):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(Math.Round(remainingFuel,3)):f2}L more fuel.");
            }
        }
    }
}
