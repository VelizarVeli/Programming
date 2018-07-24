using System;
namespace RestaurantDiscount
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string ServicePackageDiscount = Console.ReadLine();
            string HallName = " "; //the name of the hall
            var discount = 0.00; //discount in procents
            var discountPrice = 0.00; //price of the discount package
            var price = 0.00; //price of the hall 
            double totalPrice; //totalPrice 
            double priceWithDiscount = 0.00;
            var pricePerPerson = 0.00;

            if (groupSize <= 50)
            {
                HallName = "Small Hall";
                price = 2500;
            }
            else if (groupSize <= 100)
            {
                HallName = "Terrace";
                price = 5000;
            }
            else if (groupSize <= 120)
            {
                HallName = "Great Hall";
                price = 750;
            }

            switch (ServicePackageDiscount)
            {
                case "Normal":
                    discount = 0.05;
                    discountPrice = 500;
                    break;
                case "Gold":
                    discount = 0.1;
                    discountPrice = 750;
                    break;
                case "Platinum":
                    discount = 0.15;
                    discountPrice = 1000;
                    break;
            }

            //start calculating 
            totalPrice = price + discountPrice;
            priceWithDiscount = totalPrice - (discount * totalPrice);

            pricePerPerson = priceWithDiscount / groupSize;
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {HallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }

    }
}