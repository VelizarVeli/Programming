using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, long> singerMoney = new Dictionary<string, long>();
            while (input.ToLower() != "end")
            {
                string[] checkingLength = input.Split(' ').ToArray();
                if (checkingLength.Length < 4)
                {
                    goto Found;
                }
                int singerIndex = input.IndexOf("@");
                string singer = "";

                string checkSpace1 = input.Substring(singerIndex - 1, 1);
                if (checkSpace1 != " ")
                {
                    goto Found;
                }
                else
                {
                    singer = input.Substring(0, singerIndex - 1);
                }

                int totalMoneyIndex = input.LastIndexOf(' ');

                string money = input.Substring(totalMoneyIndex, input.Length - totalMoneyIndex);

                int totalMoney = int.Parse(money);

                input = input.Substring(0, totalMoneyIndex);
                totalMoneyIndex = input.LastIndexOf(' ');
                string price = "";
                try
                {
                    string price1 = input.Substring(totalMoneyIndex, input.Length - totalMoneyIndex);
                    price = price1;
                }
                catch (Exception)
                {
                    goto Found;
                }
                int priceTotal = 0;
                try
                {
                    int priceCheck = int.Parse(price);
                    priceTotal = priceCheck;
                }
                catch (Exception)
                {
                    goto Found;
                }

                try
                {
                    input = input.Substring(0, totalMoneyIndex);
                }
                catch (Exception)
                {
                    goto Found;
                }
                string venue = input.Substring(singerIndex + 1, input.Length - singerIndex - 1);

                totalMoney *= priceTotal;

                if (!data.ContainsKey(venue))
                {
                    data.Add(venue, new Dictionary<string, int>() { { singer, totalMoney } });
                }
                else if (!data[venue].ContainsKey(singer))
                {
                    data[venue].Add(singer, totalMoney);
                }
                else
                {
                    data[venue][singer] += totalMoney;
                }

                Found:
                input = Console.ReadLine();
            }
            foreach (var stage in data)
            {
                Console.WriteLine(stage.Key);
                foreach (var artist in stage.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", artist.Key, artist.Value);
                }
            }
        }
    }
}