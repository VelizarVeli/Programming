using System;
using System.Linq;
// решена за време 54 минути 100/100

namespace _01._3.ExamOctober2017
{
    class Program
    {
        static void Main(string[] args)
        {
            long countOfOrders = long.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < countOfOrders; i++)
            {

                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                string[] date = Console.ReadLine().Split(new char[]{'/'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                int year = int.Parse(date[2]);
                int month = int.Parse(date[1]);
                int daysInMonth = System.DateTime.DaysInMonth(year,month);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
                Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
