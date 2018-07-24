using System;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main()
        {
            string imperialUnit = Console.ReadLine();
            decimal value = decimal.Parse(Console.ReadLine());
            decimal european = 0;
            string metricUnit = "";

            if (imperialUnit == "miles")
            {
                european = (decimal)1.6 * value;
                metricUnit = "kilometers";
            }
            else if (imperialUnit == "inches")
            {
                european = (decimal)2.54 * value;
                metricUnit = "centimeters";

            }
            else if (imperialUnit == "feet")
            {
                european = 30 * value;
                metricUnit = "centimeters";

            }
            else if (imperialUnit == "yards")
            {
                european = (decimal)0.91 * value;
                metricUnit = "meters";

            }
            else if (imperialUnit == "gallons")
            {
                european = (decimal)3.8 * value;
                metricUnit = "liters";

            }

            Console.WriteLine($"{value} {imperialUnit} = {european:f2} {metricUnit}");
        }
    }
}
