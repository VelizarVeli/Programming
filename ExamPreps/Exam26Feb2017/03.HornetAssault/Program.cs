using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count==0)
                {
                    break;
                }
                long totalHornetsPower = hornets.Sum();

                if (beehives[i] >= totalHornetsPower)
                {
                    beehives[i] -= totalHornetsPower;
                    hornets.RemoveAt(0);
                    if (beehives[i] == 0)
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    beehives.RemoveAt(i);
                    i--;
                }
            }
            if (beehives.Count == 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            else
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
        }
    }
}
