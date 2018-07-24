using System;
// решена за време 17 минути 100/100

namespace _01._2.Exam23October2017
{
    class Program
    {
        static void Main(string[] args)
        {
            long marathonsDaysLength = int.Parse(Console.ReadLine());
            long runners = int.Parse(Console.ReadLine());
            long averageNumberLaps = int.Parse(Console.ReadLine());
            long trackLength = int.Parse(Console.ReadLine());
            long trackCapacity = int.Parse(Console.ReadLine());
            decimal ammountOfMoneyDonatedPerKm = decimal.Parse(Console.ReadLine());

            long maxRunners = marathonsDaysLength * trackCapacity;
            if (maxRunners > runners)
            {
                maxRunners = runners;
            }
            long totalKM = (maxRunners * averageNumberLaps * trackLength) / 1000; //in KM
            decimal totalMoney = ammountOfMoneyDonatedPerKm * totalKM;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
            ;
        }
    }
}
