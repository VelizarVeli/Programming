using System;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main()
        {

            int counter = 0;
            while (true)
            {
                try
                {
                int input = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    break;
                }

            }

        }
    }
}
