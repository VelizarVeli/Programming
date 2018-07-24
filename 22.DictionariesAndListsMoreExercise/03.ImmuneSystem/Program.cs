using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int healthCheck = health;
            string virusDefinition = Console.ReadLine();
            List<string> check = new List<string>();
            while (virusDefinition.ToLower() != "end")
            {

                int virusStrength = 0;
                int defeatVirusInSec = 0;
                for (int i = 0; i < virusDefinition.Length; i++)
                {
                    int letter = virusDefinition[i];
                    virusStrength += letter;
                }
                virusStrength /= 3;
                defeatVirusInSec = virusStrength * virusDefinition.Length;
                if (check.Contains(virusDefinition))
                {
                    defeatVirusInSec /= 3;
                }
                check.Add(virusDefinition);

                Console.WriteLine($"Virus {virusDefinition}: {virusStrength} => {defeatVirusInSec} seconds");
                health -= defeatVirusInSec;
                if (health > 0)
                {
                    Console.WriteLine($"{virusDefinition} defeated in {defeatVirusInSec / 60}m {defeatVirusInSec % 60}s.");
                    Console.WriteLine($"Remaining health: {health}");
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                health += (health * 20) / 100;
                if (health > healthCheck)
                {
                    health = healthCheck;
                }
              
                virusDefinition = Console.ReadLine();
            }
            if (health > 0)
            {
                Console.WriteLine($"Final Health: {health}");
            }
        }
    }
}
