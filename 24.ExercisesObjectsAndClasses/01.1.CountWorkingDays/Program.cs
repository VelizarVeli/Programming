using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace _01._1.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(input1, "dd-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(input2, "dd-M-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays = new DateTime[12];

            holidays[0] = new DateTime(4, 01, 01);
            holidays[1] = new DateTime(4, 03, 03);
            holidays[2] = new DateTime(4, 05, 01);
            holidays[3] = new DateTime(4, 05, 06);
            holidays[4] = new DateTime(4, 05, 24);
            holidays[5] = new DateTime(4, 09, 06);
            holidays[6] = new DateTime(4, 09, 22);
            holidays[7] = new DateTime(4, 11, 01);
            holidays[9] = new DateTime(4, 12, 24);
            holidays[10] = new DateTime(4, 12, 25);
            holidays[11] = new DateTime(4, 12, 26);

            int counter = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DayOfWeek day = i.DayOfWeek;

                DateTime temp = new DateTime(4, i.Month, i.Day);

                if (!holidays.Contains(temp) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
