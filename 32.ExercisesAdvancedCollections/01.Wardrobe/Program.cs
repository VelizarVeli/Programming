using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < N; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = inputTokens[0];
                string[] clothes = inputTokens[1].Split(',').ToArray();
                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }
                foreach (var cloth in clothes)
                {
                    Dictionary<string, int> clothDB = data[color];
                    if (!clothDB.ContainsKey(cloth))
                    {
                        clothDB.Add(cloth, 0);
                    }

                    clothDB[cloth]++;
                }
            }
            string[] searchTokens = Console.ReadLine().Split(' ');
            string searchedColor = searchTokens[0];
            string searchedCloth = searchTokens[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> colorData in data)
            {
                string color = colorData.Key;
                Dictionary<string, int> clothesData = colorData.Value;
                Console.WriteLine($"{color} clothes:");
                foreach (var clothData in clothesData)
                {
                    string cloth = clothData.Key;
                    int quantity = clothData.Value;
                    Console.Write($"* {cloth} - {quantity}");
                    if (color == searchedColor && cloth == searchedCloth)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
