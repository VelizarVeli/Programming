using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int length = int.Parse(Console.ReadLine());
            int counter = 0;
            int counter1 = 0;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == length)
                {
                    if (counter == 10)
                    {
                        break;
                    }
                    counter++;
                }
            }
            string[] ingredients = new string[counter];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == length)
                {
                    Console.WriteLine($"Adding {array[i]}.");
                    counter1++;
                    ingredients[j] = array[i];
                    j++;
                    if(counter1 > 9)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");

            Console.Write($"The ingredients are: ");
            for (int i = 0; i < ingredients.Length; i++)
            {
                if(ingredients.Length == i + 1)
                {
                    Console.WriteLine($"{ingredients[i]}.");
                }
                else
                {
                    Console.Write($"{ingredients[i]}, ");
                }
            }
        }
    }
}
