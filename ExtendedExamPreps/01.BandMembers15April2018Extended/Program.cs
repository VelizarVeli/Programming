using System;
//19 минути 100/100
namespace _01.BandMembers15April2018Extended
{
    class Program
    {
        static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());
            const int vocalist = 1;
            int guitarists = membersCount / 3;
            int drummers = membersCount - vocalist - guitarists;

            decimal guitarPrice = decimal.Parse(Console.ReadLine());
            decimal drumPrice = guitarPrice * 1.5M;
            decimal totalDrumPrice = drumPrice * drummers;
            decimal totalGuitarPrice = guitarPrice * guitarists;
            decimal microphonePrice = Math.Abs(totalDrumPrice - totalGuitarPrice);

            decimal totalInstrumentsPrice = totalDrumPrice + totalGuitarPrice + microphonePrice;
            decimal rent = totalInstrumentsPrice / membersCount * 12;

            decimal totalExpenses = totalInstrumentsPrice + rent;
            Console.WriteLine($"Total cost: {totalExpenses:f2}lv.");
        }
    }
}
