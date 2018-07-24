using System;
using System.Collections.Generic;
//решена втори път за време 2 часа и 26 минути 100/100

namespace _04._1.Again
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                string[] datasets = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (datasets.Length == 1)
                {
                    string onlyDataset = datasets[0];
                    if (cache.ContainsKey(onlyDataset))
                    {
                        Dictionary<string, long> keySize = new Dictionary<string, long>();
                        data.Add(onlyDataset, keySize);
                        data[onlyDataset] = cache[onlyDataset];
                    }
                    else
                    {
                        data.Add(onlyDataset, new Dictionary<string, long>());
                    }
                }
                else
                {
                    string dataKey = datasets[0];
                    long dataSize = long.Parse(datasets[1]);
                    string dataSet = datasets[2];

                    if (data.ContainsKey(dataSet))
                    {
                        if (!data[dataSet].ContainsKey(dataKey))
                        {
                            data[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            data[dataSet][dataKey] += dataSize;
                        }
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            Dictionary<string, long> keySize = new Dictionary<string, long>();
                            cache.Add(dataSet, keySize);
                        }
                        if (!cache[dataSet].ContainsKey(dataKey))
                        {
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            cache[dataSet][dataKey] += dataSize;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            if (data.Count != 0)
            {
                long biggestSum = 0;
                string winer = "";
                foreach (var dataSet in data)
                {
                    long currentValue = 0;
                    string datas = dataSet.Key;
                    Dictionary<string, long> keySize = dataSet.Value;
                    foreach (var dataSize in keySize)
                    {
                        currentValue += dataSize.Value;
                    }
                    if (currentValue > biggestSum)
                    {
                        biggestSum = currentValue;
                        winer = datas;
                    }
                }
                foreach (var dataSet in data)
                {
                    string checky = dataSet.Key;
                    if (checky == winer)
                    {
                        Console.WriteLine($"Data Set: {winer}, Total Size: {biggestSum}");
                        foreach (var dataKey in dataSet.Value)
                        {
                            Console.WriteLine($"$.{dataKey.Key}");
                        }
                    }
                }
            }
        }
    }
}
