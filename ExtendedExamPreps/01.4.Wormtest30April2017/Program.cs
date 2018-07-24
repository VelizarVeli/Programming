using System;
//решена за 15 минути 100/100

namespace _01._4.Wormtest30April2017
{
    class Program
    {
        static void Main()
        {
            decimal wormLengthInMeters = decimal.Parse(Console.ReadLine());
            decimal wormWidthInCM = decimal.Parse(Console.ReadLine());

            decimal lengthInCM = wormLengthInMeters * 100;
            try
            {
                if (lengthInCM % wormWidthInCM != 0)
                {
                    Console.WriteLine($"{lengthInCM / wormWidthInCM * 100:f2}%");
                }
                else
                {
                    Console.WriteLine($"{lengthInCM * wormWidthInCM:f2}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{lengthInCM * wormWidthInCM:f2}");
            }
        }
    }
}
