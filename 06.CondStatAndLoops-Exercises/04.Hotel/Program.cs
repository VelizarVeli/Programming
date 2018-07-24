using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double Double = 0;
            double suite = 0;

            if(month == "may" || month == "october")
            {
                studio = 50 * nights;
                Double = 65 * nights;
                suite = 75 * nights;
            }
            else if (month == "june" || month == "september")
            {
                studio = 60 * nights;
                Double = 72 * nights;
                suite = 82 * nights;
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                studio = 68 * nights;
                Double = 77 * nights;
                suite = 89 * nights;
            }

            if (nights > 7 && (month == "may" || month == "october"))
            {
                studio = studio * 0.95;
            }
            if (nights > 14 && (month == "june" || month == "september"))
            {
                Double = Double * 0.9;
            }
            if (nights > 14 && (month == "july" || month == "august" || month == "december"))
            {
                suite = suite * 0.85;
            }
            if (nights > 7 && (month == "september" || month == "october"))
            {
                studio = studio - (studio / nights);
            }
            Console.WriteLine($"Studio: {studio:f2} lv.");
            Console.WriteLine($"Double: {Double:f2} lv.");
            Console.WriteLine($"Suite: {suite:f2} lv.");
        }
    }
}
