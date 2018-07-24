using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> singerMoney = new Dictionary<string, int>();
            while (input != "End")
            {
                bool check = true;
                int singerIndex = input.IndexOf("@");
                string singer = "";

                string checkSpace1 = input.Substring(singerIndex - 1, 1);
                if (checkSpace1 != " ")
                {
                    check = false;
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
                    check = false;
                }
                int priceTotal = 0;
                try
                {
                    int priceCheck = int.Parse(price);
                    priceTotal = priceCheck;
                }
                catch (Exception)
                {
                    check = false;
                }

                try
                {
                    input = input.Substring(0, totalMoneyIndex);
                }
                catch (Exception)
                {
                    check = false;
                }
                string venue = input.Substring(singerIndex + 1, input.Length - singerIndex - 1);

                totalMoney *= priceTotal;

                if (check)
                {
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
                }

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
            //foreach (var pair in data)
            //{
            //    Console.WriteLine("{0}", pair.Key);
            //    foreach (var innerPair in pair.Value)
            //    {
            //        Console.WriteLine("#  {0} -> {1}", innerPair.Key, innerPair.Value);
            //    }
            //}
        }
    }
}
