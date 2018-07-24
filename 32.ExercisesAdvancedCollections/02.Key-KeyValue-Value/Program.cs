using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_KeyValue_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
            for (int i = 0; i < N; i++)
            {
                string[] keyValue = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                string inputKey = keyValue[0];
                string inputValue = keyValue[1];
                if (inputKey.Contains(key))
                {
                    if (!data.ContainsKey(inputKey))
                    {
                        data.Add(inputKey, new List<string>());
                    }
                    string[] items = inputValue.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in items)
                    {
                        if (item.Contains(value))
                        {
                            data[inputKey].Add(item);
                        }
                    }
                }
            }
            foreach (var keyVal in data)
            {
                string keys = keyVal.Key;
                List<string> vals = keyVal.Value;
                Console.WriteLine($"{keys}:");

                foreach (var val in vals)
                {
                    Console.WriteLine($"-{val}");
                }
            }
        }
    }
}
