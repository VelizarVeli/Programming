using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double EnergyPerHundred = double.Parse(Console.ReadLine());
            double SugarPerHundred = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{((volume * EnergyPerHundred) / 100)}kcal, {((volume * SugarPerHundred) / 100)}g sugars");
        }
    }
}
