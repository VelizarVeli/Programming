using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "thetinggoesskrra")
            {
                if (input.Length == 1)
                {
                    string dataSet = input[0];
                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                        if (cache.ContainsKey(dataSet))
                        {
                            foreach (var set in cache)
                            {
                                string dataSe = set.Key;
                                Dictionary<string, long> keySize = set.Value;
                                if (dataSe == dataSet)
                                {
                                    foreach (var item in keySize)
                                    {
                                        string ke = item.Key;
                                        long siz = item.Value;
                                        if (!data[dataSet].ContainsKey(ke))
                                        {
                                            data[dataSet].Add(ke, siz);
                                        }
                                    }
                                }
                            }
                            cache.Remove(dataSet);
                        }
                    }
                }
                else
                {
                    string dataKey = input[0];
                    long dataSize = long.Parse(input[1]);
                    string dataSet = input[2];
                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                        }
                        cache[dataSet].Add(dataKey, dataSize);

                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
            }
            BigInteger total = 0;
            string checky = "";
            foreach (var set in data)
            {
                string se = set.Key;
                Dictionary<string, long> keySize = set.Value;
                BigInteger current = 0;
                foreach (var item in keySize)
                {
                    current += item.Value;
                }
                if (current > total)
                {
                    total = current;
                    checky = se;
                }
            }
            Console.WriteLine($"Data Set: {checky}, Total Size: {total}");
            foreach (var set in data)
            {
                string se = set.Key;
                Dictionary<string, long> keySize = set.Value;
                long current = 0;
                foreach (var item in keySize)
                {
                    if (se == checky)
                    {
                        Console.WriteLine($"$.{item.Key}");
                    }
                }
            }
        }
    }
}
