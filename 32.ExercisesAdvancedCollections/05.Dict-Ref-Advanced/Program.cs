using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
            while (input[0] != "end")
            {
                string name = input[0];
                List<string> values = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();


                if (IsNumber(input[1]))
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<string>());
                    }
                    data[name].AddRange(values);
                }
                else
                {
                    if (data.ContainsKey(values[0]))
                    {
                        List<string> oldName = data[values[0]];
                        data.Add(name, oldName);
                    }
                }

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (KeyValuePair<string, List<string>> name in data)
            {
                string nam = name.Key;
                List<string> ints = name.Value;
                Console.WriteLine($"{nam} === {string.Join(", ", ints)}");
            }
        }
        static bool IsNumber(string name)
        {
            foreach (var ch in name)
            {
                if (char.IsLetter(ch))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
