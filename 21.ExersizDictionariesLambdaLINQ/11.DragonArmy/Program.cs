using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, double[]>> data = new Dictionary<string, SortedDictionary<string, double[]>>();
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                string type = input[0];
                string name = input[1];
                double damage = 0;
                double health = 0;
                double armor = 0;

                damage = input[2] != "null" ? double.Parse(input[2]) : 45;
                health = input[3] != "null" ? double.Parse(input[3]) : 250;
                armor = input[4] != "null" ? double.Parse(input[4]) : 10;
                double[] stats = new double[] { damage, health, armor };

                if (!data.ContainsKey(type))
                {

                    data.Add(type, new SortedDictionary<string, double[]>() { { name, stats } });
                }
                else if (!data[type].ContainsKey(name))
                {
                    data[type].Add(name, stats);
                }
                else
                {
                    data[type][name] = stats;
                }
                
            }
            foreach (var type in data)
            {
                double avDamage = type.Value.Values.Average(aver => aver[0]);
                double avHealth = type.Value.Values.Average(aver => aver[1]);
                double avArmor = type.Value.Values.Average(aver => aver[2]);
                Console.WriteLine($"{type.Key}::({avDamage:f2}/{avHealth:f2}/{avArmor:f2})");
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
