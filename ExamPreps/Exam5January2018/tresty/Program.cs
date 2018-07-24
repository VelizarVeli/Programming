using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Snowwhite
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<KeyValuePair<long, string>>> data = new Dictionary<string, List<KeyValuePair<long, string>>>();

            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] dwarf = input.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = dwarf[0];
                string hatColor = dwarf[1];
                long physics = long.Parse(dwarf[2]);

                if (!data.ContainsKey(name))
                {
                    List<KeyValuePair<long, string>> checky = new List<KeyValuePair<long, string>>();
                    checky.Add(new KeyValuePair<long, string>(physics,hatColor));
                    data.Add(name, checky);
                    
                }

                //if (data[name].ContainsKey(hatColor))
                //{
                //    long checkPhysics = data[name][hatColor];
                //    if (checkPhysics < physics)
                //    {
                //        data[name][hatColor] = physics;
                //    }
                //}

                input = Console.ReadLine();
            }

            foreach (var item in data.OrderByDescending(a=>a.Value))
            {
                List<KeyValuePair<long, string>> physyHat = item.Value;
                string nam = item.Key;

                foreach (var check in physyHat.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"({check.Value}) {nam} <-> {check.Key}");
                }
            }
        }
    }
}
