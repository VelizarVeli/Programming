using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            SortedDictionary<long, Dictionary<string, string>> sortiram = new SortedDictionary<long, Dictionary<string, string>>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] dwarf = input.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = dwarf[0];
                string hatColor = dwarf[1];
                long physics = long.Parse(dwarf[2]);

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new Dictionary<string, long>());
                }
                if (!data[name].ContainsKey(hatColor))
                {
                    data[name].Add(hatColor, physics);
                }
                if (data[name].ContainsKey(hatColor))
                {
                    long checkPhysics = data[name][hatColor];
                    if (checkPhysics < physics)
                    {
                        data[name][hatColor] = physics;
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var namen in data)
            {
                string nam = namen.Key;
                Dictionary<string, long> hatPhys = namen.Value;
                foreach (var phys in hatPhys)
                {
                    string color = phys.Key;
                    long physy = phys.Value;
                    if (!sortiram.ContainsKey(physy))
                    {
                        sortiram.Add(physy,new Dictionary<string, string>());
                        sortiram[physy].Add(nam);
                    }
                }
            }
        }
    }
}
