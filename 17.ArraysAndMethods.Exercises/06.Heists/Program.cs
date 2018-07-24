using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] loots = Console.ReadLine().Split(' ').ToArray();
            long income = 0;
            do
            {
                char[] jewels = loots[0].ToCharArray();
                for (int i = 0; i < jewels.Length; i++)
                {
                    if(jewels[i] == '%')
                    {
                        income += prices[0];
                    }
                    else if (jewels[i] == '$')
                    {
                        income += prices[1];
                    }
                }
                int losses = int.Parse(loots[1]);
                income -= losses;
                loots = Console.ReadLine().Split(' ').ToArray();
            } while (loots[0] != "Jail" && loots[1] != "Time");
            if(income >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {income}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(income)}.");
            }
        }
    }
}
