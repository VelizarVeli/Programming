using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string str1 = input[0];
            string str2 = input[1];
            long sum = 0;
            int longer = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < longer; i++)
            {
                long letter1 = (str1[i]);
                long letter2 = (str2[i]);
                sum += letter1 * letter2;
            }
            if (str1.Length != str2.Length)
            {
                if (str1.Length > str2.Length)
                {
                    int j = str2.Length;
                    for (int i = 0; i < str1.Length - str2.Length; i++)
                    {
                        long letter1 = (str1[j]);
                        sum += letter1;
                        j++;
                    }
                }
                else
                {
                    int j = str1.Length;
                    for (int i = 0; i < str2.Length - str1.Length; i++)
                    {
                        long letter2 = (str2[j]);
                        sum += letter2;
                        j++;
                    }
                }
            }//aaaa a
            Console.WriteLine(sum);
        }
    }
}
