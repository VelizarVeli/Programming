using System;
using System.Collections.Generic;
using System.Linq;
//решена за време с класове и обекти за 1 час и десет минути 100/100
namespace _04._1.SnowhiteWithClassAndObject
{
    class Program
    {
        static void Main()
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputArray = input.Split(new[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = inputArray[0];
                string dwarfHatColor = inputArray[1];
                long dwarfPhysics = long.Parse(inputArray[2]);

                Dwarf dwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);
                bool check = true;
                foreach (var dwarfy in dwarfs)
                {
                    if (dwarfy.HatColor == dwarfHatColor && dwarfy.Name == dwarfName)
                    {
                        long bigger = Math.Max(dwarfy.Physics, dwarfPhysics);
                        dwarfy.Physics = bigger;
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    dwarfs.Add(dwarf);
                }
            }

            foreach (var dwarf in dwarfs.OrderByDescending(a => a.Physics)
                .ThenByDescending(x => dwarfs.Where(y => y.HatColor == x.HatColor).Count()))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        public class Dwarf
        {
            public string Name { get; set; }
            public string HatColor { get; set; }
            public long Physics { get; set; }

            public Dwarf(string name, string hatColor, long physics)
            {
                this.Name = name;
                this.HatColor = hatColor;
                this.Physics = physics;
            }
        }
    }
}
