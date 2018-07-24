using System;
// решена за време 50 минути 100/100


namespace _01._5.ExamJune2016
{
    class Program
    {
        static void Main()
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal oneBananaPrice = decimal.Parse(Console.ReadLine());
            decimal oneEggPrice = decimal.Parse(Console.ReadLine());
            decimal oneKiloBerriesPrice = decimal.Parse(Console.ReadLine());


            decimal sets = Math.Floor(guests / 6);
            if (guests % 6 != 0)
            {
                sets++;
            }
            decimal bananasPrice = 2 * oneBananaPrice * sets;
            decimal eggsPrice = 4 * oneEggPrice * sets;
            decimal berriesPrice = 0.2m * oneKiloBerriesPrice * sets;
            decimal costProducts = bananasPrice + eggsPrice + berriesPrice;

            if (amountOfCash >= costProducts)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {costProducts:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {costProducts - amountOfCash:f2}lv more.");
            }
        }
    }
}
