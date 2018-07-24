using System;
using System.Linq;

namespace _02.KaminoFactory04March2018
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int sampleCounter = 0;
            int onesMaxCounter = -1;
            string input;
            BestShot best = new BestShot();
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                sampleCounter++;

                int[] sample = input.Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currCounter = 0;
                int currentMaxCount = 0;
                bool startIndex = true;
                int currIndex = 0;
                int start = 0;

                for (int i = 0; i < sample.Length; i++)
                {
                    if (sample[i] == 1)
                    {
                        currCounter++;
                        if (startIndex)
                        {
                            currIndex = i;
                            startIndex = false;
                        }
                    }
                    else
                    {
                        startIndex = true;
                        if (currCounter > currentMaxCount)
                        {
                            currentMaxCount = currCounter;
                            currCounter = 0;
                            start = currIndex;
                        }
                    }

                    if (i == sample.Length - 1 && sample[i] == 1)
                    {
                        if (currCounter > currentMaxCount)
                        {
                            currentMaxCount = currCounter;
                            currCounter = 0;
                            start = currIndex;
                        }
                    }
                }

                if (onesMaxCounter <= currentMaxCount)
                {
                    if (onesMaxCounter == currentMaxCount)
                    {
                        if (best.Index > start)
                        {
                            onesMaxCounter = currentMaxCount;
                            best.Row = sampleCounter;
                            best.MaxCount = onesMaxCounter;
                            int length = sample.Sum();
                            best.Sample = sample;
                            best.Index = start;
                            best.SumOfAllElements = length;
                        }
                    }
                    else
                    {
                        onesMaxCounter = currentMaxCount;
                        best.Row = sampleCounter;
                        best.MaxCount = onesMaxCounter;
                        int length = sample.Sum();
                        best.Sample = sample;
                        best.Index = start;
                        best.SumOfAllElements = length;
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {best.Row} with sum: {best.SumOfAllElements}.");
            Console.WriteLine($"{string.Join(" ", best.Sample)}");
        }

        public class BestShot
        {
            public int Row { get; set; }
            public int MaxCount { get; set; }
            public int[] Sample { get; set; }
            public int Index { get; set; }
            public int SumOfAllElements { get; set; }
        }
    }
}
