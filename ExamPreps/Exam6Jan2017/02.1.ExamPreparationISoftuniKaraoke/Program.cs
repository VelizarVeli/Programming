using System;
using System.Linq;

// решена за време 1 час и 46 минути 100/100 с малка подсказка use .Contains
namespace _02._1.ExamPreparationI
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split().ToArray();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            long[] indeces = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int j = 0; j < names.Length; j++)
            {
                string currentName = names[j];
                double fuel = currentName[0];
                long index = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    if (index < indeces.Length)
                    {
                        if (indeces.Contains(i))
                        {
                            fuel += zones[i];
                        }
                        else
                        {
                            fuel -= zones[i];
                            if (fuel <= 0)
                            {
                                Console.WriteLine($"{currentName} - reached {i}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        fuel -= zones[i];
                        if (fuel <= 0)
                        {
                            Console.WriteLine($"{currentName} - reached {i}");
                            break;
                        }
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{currentName} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
