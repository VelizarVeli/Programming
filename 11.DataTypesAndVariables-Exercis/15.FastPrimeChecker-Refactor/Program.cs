using System;

namespace _15.FastPrimeChecker_Refactor
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int check = 0;
            bool primeCheck = true;
            for (check = 2; check <= num; check++)
            {
                primeCheck = true;
                for (int delio = 2; delio <= Math.Sqrt(check); delio++)
{
                if (check % delio == 0)
                {
                    primeCheck = false;
                    break;
                }
            }
            Console.WriteLine($"{check} -> {primeCheck}");
        }
    }
}
}
