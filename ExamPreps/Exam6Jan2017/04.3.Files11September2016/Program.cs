using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._3.Files11September2016
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = new string[N];

            for (int i = 0; i < N; i++)
            {
                input[i] = Console.ReadLine();
            }

            string[] neededFile = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string neededExtention = "." + neededFile[0];
            string nededPath = neededFile[2] + "\\";

            Dictionary<string, long> data = new Dictionary<string, long>();
            for (int j = 0; j < N; j++)
            {
                string extentionAndFilesize = input[j].Substring(input[j].LastIndexOf("\\") + 1);
                string path = input[j].Substring(0, input[j].Length - extentionAndFilesize.Length - 1);
                string[] extFile = extentionAndFilesize.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string currentExtention = extFile[0];
                long currentKb = long.Parse(extFile[1]);
                if (extentionAndFilesize.Contains(neededExtention) && path.Contains(nededPath))
                {
                    if (!data.ContainsKey(currentExtention))
                    {
                        data.Add(currentExtention, currentKb);
                    }
                    data[currentExtention] = currentKb;
                }
            }
            if (data.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in data.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string fileExt = file.Key;
                    long fileSize = file.Value;
                    Console.WriteLine($"{fileExt} - {fileSize} KB");
                }
            }
        }
    }
}
