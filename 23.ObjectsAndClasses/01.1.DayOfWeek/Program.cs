using System;
using System.Globalization;

//Read the date as string from the Console.
//Use the method DateTime.ParseExact(string date, format, provider) to convert the input
//string to object of type DateTime. Use format “d-M- yyyy” and CultureInfo.InvariantCulture.
//o Alternatively split the input by “-“ and you will get the day, month and year as numbers.Now you
//can create new DateTime(year, month, day).
// The newly created DateTime object has property DayOfWeek.

namespace _01._1.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            string date = Console.ReadLine();
            var date1 = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            var weekDay = date1.DayOfWeek;
            Console.WriteLine(weekDay);

            string[] date12 = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
            int day = int.Parse(date12[0]);
            int month = int.Parse(date12[1]);
            int year = int.Parse(date12[2]);
            var date2 = new DateTime(year, month, day);
            Console.WriteLine(date2.DayOfWeek);
        }
    }
}
