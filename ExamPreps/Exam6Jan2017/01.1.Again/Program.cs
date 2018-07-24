using System;
using System.Linq;
// решена втори път за време 34 минути 100/100
namespace _01._1.Again
{
    class Program
    {
        static void Main()
        {
            long[] leavingtime = Console.ReadLine().Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            long numberOfSteps = long.Parse(Console.ReadLine());
            long timeForAStep = long.Parse(Console.ReadLine());

            long leaveSeconds = leavingtime[2];
            long leaveMinutes = leavingtime[1];
            long leavehours = leavingtime[0];

            long leavingTimeInSec = leaveSeconds + (leaveMinutes * 60) + (leavehours * 60 * 60);
            long walkingTimeInSec = numberOfSteps * timeForAStep;

            long totalInSec = leavingTimeInSec + walkingTimeInSec;

            long secsArrived = totalInSec % 60;
            long mins = totalInSec / 60;
            long minsArrived = mins % 60;
            long hours = mins / 60;
            long hourArrived = hours % 24;

            Console.WriteLine($"Time Arrival: {hourArrived:d2}:{minsArrived:d2}:{secsArrived:d2}");
        }
    }
}
