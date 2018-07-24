using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float metersPerSecond = distanceInMeters / ((hours * 3600) + (minutes * 60) + seconds);
            float kmPerHour = (distanceInMeters / 1000) / (hours + (minutes / 60) + (seconds / 3600));
            float milesPerHour = ((distanceInMeters / 1000) / 1.609f) / (hours + (minutes / 60) + (seconds / 3600));

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
