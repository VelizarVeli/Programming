using System;
// решена за време 38 минути 100/100

namespace _02._13.BussesTelerik
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] busses = new int[N];
            for (int i = 0; i < N; i++)
            {
                busses[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            int currentLowestSpeed = Int32.MaxValue;
            for (int i = 0; i < N; i++)
            {
                if (currentLowestSpeed >= busses[i])
                {
                    counter++;
                    currentLowestSpeed = busses[i];
                }
            }
            Console.WriteLine(counter);
        }
    }
}
