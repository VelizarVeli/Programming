using System;

namespace _08.CharacterStats
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int curHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int curEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|",new string('|', curHealth), new string('.', maxHealth - curHealth));
            Console.WriteLine("Energy: |{0}{1}|",new string('|', curEnergy), new string('.', maxEnergy - curEnergy));
        }
    }
}
