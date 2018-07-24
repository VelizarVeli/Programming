using System;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main()
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healthGosho = 100;
            int round = 1;

            while (true)
            {
                if (round % 2 == 1)
                {
                    healthGosho = healthGosho - damagePesho;
                    if (healthPesho <= 0 || healthGosho <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else
                {
                    healthPesho = healthPesho - damageGosho;
                    if (healthGosho <= 0 || healthPesho <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }
                if (round % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
                round++;
            }
            if (healthPesho < healthGosho)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
        }
    }
}
