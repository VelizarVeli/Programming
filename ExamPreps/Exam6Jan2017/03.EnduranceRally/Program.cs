using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            decimal[] zones = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            List<decimal> checkpoints = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                decimal startFuel = name[0];
                List<decimal> checky = new List<decimal>(checkpoints);
                for (int j = 0; j < zones.Length; j++)
                {
                    if (checky.Count == 0)
                    {
                        startFuel -= zones[j];
                    }
                    else
                    {
                        //Промяна №1
                        if (checky.Contains(j))
                        {
                            startFuel += zones[j];
                            //Промяна №2
                        }
                        else
                        {
                            startFuel -= zones[j];
                        }
                    }

                    if (startFuel <= 0)
                    {
                        Console.WriteLine($"{names[i]} - reached {j}");
                        break;
                    }
                }
                if (startFuel > 0)
                {
                    Console.WriteLine($"{names[i]} - fuel left {startFuel:f2}");
                }
            }
        }
    }
}