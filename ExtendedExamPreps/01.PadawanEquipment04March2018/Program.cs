using System;
//41 мин 100/100
namespace _01.PadawanEquipment04March2018
{
    class Program
    {
        static void Main()
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            int beltsNeeded = students;
            if (students >= 6)
            {
                beltsNeeded = students - students / 6;
            }

            decimal lightsabers = lightsaberPrice * (int)Math.Ceiling(students * 1.1);
            decimal neededMoney = lightsabers + robePrice * students + beltPrice * beltsNeeded;

            if (amountOfMoney >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(neededMoney - amountOfMoney):f2}lv more.");
            }
        }
    }
}
