using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            long count = 0;
            for (int i = 0; i < N; i++)
            {
                string[] site = Console.ReadLine().Split(new char[] { ' ', '\n'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                string siteName = site[0];
                long siteVisits = long.Parse(site[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(site[2]);
                Console.WriteLine(siteName);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
                count++;
            }
            BigInteger securityToken = (BigInteger)Math.Pow(securityKey,count);
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
