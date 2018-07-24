using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentNum = 0;
            int num = 0;
            bool check = true;

            int counterBiggest = 1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
            int currenCounter = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[i] == array[j])
                    {
                        currenCounter++;
                        currentNum = array[i];
                        check = false;
                    }
                }
                if (currenCounter >= counterBiggest)
                {
                    counterBiggest = currenCounter;
                    num = currentNum;
                }
            }
            if (check)
            {
                Console.WriteLine(array[0]);
            }
            else
            Console.WriteLine(num);
        }
    }
}
