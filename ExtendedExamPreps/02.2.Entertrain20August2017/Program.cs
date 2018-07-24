using System;
using System.Collections.Generic;
using System.Linq;
//решена за 51 минути 100/100

namespace _02._2.Entertrain20August2017
{
    class Program
    {
        static void Main()
        {
            int LokomotivePower = int.Parse(Console.ReadLine());
            long sum = 0;
            List<long> wagons = new List<long>();
            string currentWagon = Console.ReadLine();
            while (currentWagon != "All ofboard!")
            {
                long currentWagon1 = long.Parse(currentWagon);
                sum += currentWagon1;
                wagons.Add(currentWagon1);
                if (sum > LokomotivePower)
                {
                    long aver = (long)wagons.Average();
                    long closest = wagons.Aggregate((x, y) => Math.Abs(x - aver) < Math.Abs(y - aver) ? x : y);
                    wagons.Remove(closest);

                }
                currentWagon = Console.ReadLine();
            }
            wagons.Reverse();
            wagons.Add(LokomotivePower);
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
