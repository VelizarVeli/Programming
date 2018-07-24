using System;

// решена за време 23 минути 100/100


namespace _02._11.MixingNumbersTelerik
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] mixed = new int[N - 1];
            int[] subtracted = new int[N - 1];
            for (int i = 0; i < N - 1; i++)
            {
                int currentMix = array[i] % 10 * (array[i + 1] / 10);
                mixed[i] = currentMix;

                int currentSub = Math.Abs(array[i] - array[i + 1]);
                subtracted[i] = currentSub;
            }
            Console.WriteLine(string.Join(" ", mixed));
            Console.WriteLine(string.Join(" ", subtracted));
        }
    }
}
