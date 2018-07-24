using System;

namespace tests
{
    class Program
    {
        static void Main()
        {
            int j = int.Parse(Console.ReadLine());
            int sum = 0;

            while (j != 0)
            {

                sum += j % 10;
                j /= 10;
            }
            

            Console.WriteLine(sum);
        }
    }
}
