using System;

namespace _01.ChooseADrink
{
    class Program
    {
        static void Main()
        {
            string proffession = Console.ReadLine().ToLower();

            switch (proffession)
            {
                case "athlete":
                    Console.WriteLine("Water");
                    break;
                case "businessman":
                case "businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "softuni student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
