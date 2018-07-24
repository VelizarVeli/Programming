using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftuniKaraokePartI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leaveTime = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long steps = long.Parse(Console.ReadLine());
            long timeForAStep = long.Parse(Console.ReadLine());

            long totalLeaveTimeInSeconds = (leaveTime[0] * 60 * 60) + (leaveTime[1] * 60) + leaveTime[2];
            long totalNeededTimeInSecods = steps * timeForAStep;
            long totalInSeconds = totalLeaveTimeInSeconds + totalNeededTimeInSecods;

            var seconds = totalInSeconds % 60;
            var totalMinutes = totalInSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;
            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
