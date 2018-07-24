using System;
using System.Collections.Generic;
using System.Linq;
//1 час и 2 минути 100/100
namespace _02.DrumSet15April2018Extended
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> drumsQuality = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> drumsToBeat = new List<int>(drumsQuality);
            
            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int inp = int.Parse(input);

                for (int i = 0; i < drumsToBeat.Count; i++)
                {
                    drumsToBeat[i] -= inp;
                    if (drumsToBeat[i] <= 0)
                    {
                        decimal drumPrice = drumsQuality[i] * 3;
                        if (savings - drumPrice > 0)
                        {
                            drumsToBeat[i] = drumsQuality[i];
                            savings -= drumPrice;
                        }
                        else
                        {
                            drumsToBeat.RemoveAt(i);
                            drumsQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumsToBeat));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
