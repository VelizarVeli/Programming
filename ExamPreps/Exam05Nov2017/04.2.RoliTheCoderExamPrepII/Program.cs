using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2.RoliTheCoderExamPrepII
{
    class Program
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            Dictionary<List<KeyValuePair<int,string>>, List<string>> data = new Dictionary<List<KeyValuePair<int, string>>, List<string>>();
            while (input1 != "Time for Code")
            {
                string[] input = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string eventName = input[1];
                string check = eventName.Substring(0, 1);
                if (check != "#")
                {
                    continue;
                }
                eventName = eventName.Substring(1);
                int ID = int.Parse(input[0]);
                if (!data.ContainsKey(ID))
                {
                    data.Add(ID, new Dictionary<string, List<string>>());
                }
                if (!data[ID].ContainsKey(eventName))
                {
                    List<string> current = new List<string>();
                    for (int i = 2; i < input.Length; i++)
                    {
                        current.Add(input[i]);
                    }
                    data[ID][eventName] = current;
                }
                if (data.ContainsKey(ID))
                {
                    if (data[ID][eventName].Contains(eventName))
                    {
                        for (int i = 2; i < input.Length; i++)
                        {
                            data[ID][eventName].Add(input[i]);
                        }
                    }
                }
                input1 = Console.ReadLine();
            }
            foreach (var cupon in data.OrderByDescending(a => a.Key))
            {
                Console.WriteLine($"{cupon.Value.Keys} - {cupon.Key}");
            }
        }
    }
}
