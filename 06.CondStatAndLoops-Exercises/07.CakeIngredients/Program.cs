using System;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main()
        {
            string ingredient = Console.ReadLine();
            int counter = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
                counter++;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
