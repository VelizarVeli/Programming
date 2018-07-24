using System;

namespace _01.RageExpenses
{
    class Program
    {
        static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headset = decimal.Parse(Console.ReadLine());
            decimal mouse = decimal.Parse(Console.ReadLine());
            decimal keyboard = decimal.Parse(Console.ReadLine());
            decimal display = decimal.Parse(Console.ReadLine());
            decimal totalCost = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    totalCost += headset;
                }

                if (i % 3 == 0)
                {
                    totalCost += mouse;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    totalCost += keyboard;
                    displayCount++;
                    if (displayCount == 2)
                    {
                        totalCost += display;
                        displayCount = 0;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");
        }
    }
}
