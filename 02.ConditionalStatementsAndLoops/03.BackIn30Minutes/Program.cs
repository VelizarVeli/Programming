using System;

namespace _03.BackIn30Minutes
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int plus30minutes = minutes + 30;

            if (plus30minutes > 59)
            {
                hours++;
                plus30minutes = plus30minutes - 60;
                if(hours > 23)
                {
                    hours = 0;
                }
                
            }
            if (plus30minutes < 10)
            {
                Console.WriteLine($"{hours}:{plus30minutes:d2}");

            }
            else
            Console.WriteLine($"{hours}:{plus30minutes}");
        }
    }
}
