using System;

namespace _06.TheatrePromotions
{
    class Program
    {
        static void Main()
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;
            bool n = true;

            if (age >= 0 && age <= 18)
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                else if (day == "weekend")
                {
                    price = 15;
                }
                else if (day == "holiday")
                {
                    price = 5;
                }
                n = false;
            }
            else if (age > 18 && age <= 64)
            {
                if (day == "weekday")
                {
                    price = 18;
                }
                else if (day == "weekend")
                {
                    price = 20;
                }
                else if (day == "holiday")
                {
                    price = 12;
                }
                n = false;
            }
            else if (age > 64 && age <= 122)
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                else if (day == "weekend")
                {
                    price = 15;
                }
                else if (day == "holiday")
                {
                    price = 10;
                }
                n = false;
            }
            if (n)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
