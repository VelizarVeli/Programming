using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Split(' ').ToArray();
            int length = Math.Min(array1.Length, array2.Length);
            int counter1 = 0;
            int counter2 = 0;
            string[] revArray1 = array1.Reverse().ToArray();
            string[] revArray2 = array2.Reverse().ToArray();
            for (int i = 0; i < length; i++)
            {
                bool areEqual = array1[i].SequenceEqual(array2[i]);
                if (areEqual)
                {
                    counter1++;
                }
                bool areEqual2 = revArray1[i].SequenceEqual(revArray2[i]);
                if (areEqual2)
                {
                    counter2++;
                }
            }
            Console.WriteLine(Math.Max(counter1,counter2));
        }
    }
}
