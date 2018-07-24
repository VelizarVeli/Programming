    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _03.FoldAndSum
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int[] sumArr = new int[(array.Length / 4) * 2];
                int[] startReversedArr = new int[array.Length / 4];
                int[] endReversedArr = new int[array.Length / 4];

                for (int i = 0; i < array.Length / 4; i++)
                {
                    startReversedArr[i] = array[i];
                }
                int j = 1;
                for (int i = array.Length - 1; j <= endReversedArr.Length; i--)
                {
                    endReversedArr[j - 1] = array[i];
                    j++;
                }
                Array.Reverse(startReversedArr);
                j = array.Length / 4;
                int broiach = 1;
                for (int i = 0; i < sumArr.Length; i++)
                {
                    if(i < sumArr.Length / 2)
                    {
                        sumArr[i] = startReversedArr[i] + array[j];
                        j++;
                    }
                    else
                    {
                        sumArr[i] = endReversedArr[broiach - 1] + array[j];
                        broiach++;
                        j++;
                    }
                }
                for (int i = 0; i < sumArr.Length; i++)
                {
                    Console.Write($"{sumArr[i]} ");
                }
            }
        }
    }
