using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] raw = Console.ReadLine().Split(':', ' ', ',').ToArray();
            List<string> input = raw.Distinct().ToList();
            for (int i = 0; i < input.Count; i++)
            {
                input.Remove("");
            }

            while (input[0] != "JOKER")
            {
                Dictionary<string, string> currentDict = new Dictionary<string, string>();
                List<string> currList = new List<string>();
                for (int i = 1; i < input.Count; i++)
                {
                    string temp = input[i];
                    string tem1 = temp.Substring(temp.Length - 1, 1);
                    temp = temp.Remove(temp.Length - 1, 1);
                    currList.Add(temp);
                    currList.Add(tem1);
                }

                raw = Console.ReadLine().Split(':', ' ', ',').ToArray();
                input = raw.Distinct().ToList();
                for (int i = 0; i < input.Count; i++)
                {
                    input.Remove("");
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
