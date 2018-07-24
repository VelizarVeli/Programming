using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exam5January2018
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger biggest = 0;
            BigInteger currentCalc = 0;
            BigInteger snow1 = 0;
            BigInteger time1 = 0;
            BigInteger quality1 = 0;
            BigInteger result1 = 0;
            for (int i = 0; i < N; i++)
            {
                BigInteger snow = BigInteger.Parse(Console.ReadLine());
                BigInteger time = BigInteger.Parse(Console.ReadLine());
                BigInteger quality = BigInteger.Parse(Console.ReadLine());
                BigInteger result = snow / time;
                BigInteger stepen = 1;
                for (int j = 0; j < quality; j++)
                {
                    stepen *= result;
                }
                currentCalc = stepen;
                if (biggest <= currentCalc)
                {
                    snow1 = snow;
                    time1 = time;
                    quality1 = quality;
                    result1 = stepen;
                    biggest = currentCalc;
                }
            }
            Console.WriteLine($"{snow1} : {time1} = {result1} ({quality1})");
        }
    }
}
