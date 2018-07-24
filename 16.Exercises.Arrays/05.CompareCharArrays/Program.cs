using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int smaller = Math.Min(arr1.Length, arr2.Length);
            bool whichOne = true;
            for (int i = 0; i < smaller; i++)
            {
                if(arr2[i] < arr1[i])
                {
                    whichOne = false;
                }
            }
            if (whichOne && smaller == arr1.Length)
            {
                Console.WriteLine(string.Join("",arr1));
                Console.WriteLine(string.Join("",arr2));
            }
            else
            {
                Console.WriteLine(string.Join("",arr2));
                Console.WriteLine(string.Join("",arr1));
            }
        }
    }
}
