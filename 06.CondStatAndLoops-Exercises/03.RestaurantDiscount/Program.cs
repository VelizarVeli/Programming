using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double pricePerHall = 0;
            string hall = "";

            double pricePerPerson = 0;

            if(groupSize <= 50)
            {
                pricePerHall = 2500;
                hall = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                pricePerHall = 5000;
                hall = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                pricePerHall = 7500;
                hall = "Great Hall";
            }

            if (package == "normal")
            {
                pricePerPerson = ((pricePerHall + 500) * 0.95) / groupSize;
            }
            else if (package == "gold")
            {
                pricePerPerson = ((pricePerHall + 750) * 0.9) / groupSize;
            }
            else if (package == "platinum")
            {
                pricePerPerson = ((pricePerHall + 1000) * 0.85) / groupSize;
            }



            if (pricePerHall != 0)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
