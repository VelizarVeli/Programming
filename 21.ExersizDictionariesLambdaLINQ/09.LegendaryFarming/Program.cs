using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
            SortedDictionary<string, int> artefacts = new SortedDictionary<string, int> { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            int i = 1;
            int Dragonwrath = 0;
            int Valanyr = 0;
            int Shadowmourne = 0;

            while (true)
            {

                for (i = 1; i < input.Length; i += 2)
                {
                    string material = input[i];
                    int quantity = (int.Parse(input[i - 1]));

                    if (material == "shards")
                    {
                        Shadowmourne += quantity;

                        artefacts[material] += quantity;

                        if (Shadowmourne > 249)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            artefacts["shards"] -= 250;

                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        Valanyr += quantity;

                        artefacts[material] += quantity;

                        if (Valanyr > 249)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            artefacts["fragments"] -= 250;

                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        Dragonwrath += quantity;

                        artefacts[material] += quantity;

                        if (Dragonwrath > 249)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            artefacts["motes"] -= 250;

                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }
                if (Shadowmourne > 249 || Valanyr > 249 || Dragonwrath > 249)
                {
                    break;
                }
                input = Console.ReadLine().ToLower().Split(' ').ToArray();
            }
            foreach (var art in artefacts.OrderByDescending(value => value.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{art.Key}: {art.Value}");
            }

            foreach (var ju in junk)
            {
                Console.WriteLine($"{ju.Key}: {ju.Value}");
            }
        }
    }
}
