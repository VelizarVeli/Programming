using System;
using System.Linq;
using System.Numerics;
//Решена за втори път 100/100 за 21 минути
namespace _01._1.Again
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            for (int i = 0; i < N; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string siteName = data[0];
                decimal siteVisits = decimal.Parse(data[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(data[2]);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
                Console.WriteLine(siteName);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            BigInteger securityToken = 1;
            for (int i = 0; i < N; i++)
            {
                securityToken *= securityKey;
            }
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
