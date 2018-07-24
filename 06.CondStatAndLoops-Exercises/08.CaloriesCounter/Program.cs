using System;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int totalCalories = 0;

            for (int i = 0; i < lines; i++)
            {
                string product = Console.ReadLine().ToLower();

                if (product == "cheese")
                {
                    totalCalories += cheese;
                }
                else if (product == "salami")
                {
                    totalCalories += salami;
                }
                else if (product == "tomato sauce")
                {
                    totalCalories += tomatoSauce;
                }
                else if (product == "pepper")
                {
                    totalCalories += pepper;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
