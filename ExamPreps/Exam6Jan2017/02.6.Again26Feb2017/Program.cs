using System;
using System.Collections.Generic;
using System.Linq;

// решена за време 1 час и 15 минути 80/100 
namespace _02._6.Again26Feb2017
{
    class Program
    {
        static void Main()
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            int firstHornet = 0;
            long summedHornetPower = 0;

            for (int i = 0; i < hornets.Count; i++)
            {
                summedHornetPower += hornets[i];
            }

            for (int j = 0; j < beehives.Count; j++)
            {
                if (beehives[j] >= summedHornetPower)
                {
                    hornets[firstHornet] = 0;
                    firstHornet++;
                    beehives[j] -= summedHornetPower;
                    summedHornetPower = 0;
                    for (int a = 0; a < hornets.Count; a++)
                    {
                        summedHornetPower += hornets[a];
                    }
                }
                else
                {
                    beehives[j] = 0;
                }
            }
            long beehivesPower = 0;
            for (int l = 0; l < beehives.Count; l++)
            {
                beehivesPower += beehives[l];
            }
            if (beehivesPower > 0)
            {
                var newList = beehives.Where(i => i != 0).ToList();
                Console.WriteLine(string.Join(" ", newList));
            }
            else
            {
                var newList = hornets.Where(i => i != 0).ToList();

                Console.WriteLine(string.Join(" ", newList));
            }
        }
    }
}