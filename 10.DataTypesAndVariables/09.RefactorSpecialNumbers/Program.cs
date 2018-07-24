using System;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

           bool toe = false;
            for (int ch = 1; ch <= num; ch++)
{
                int takova = ch;
                while (ch > 0)
{
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($&quot;
                { takova}
                -&gt;
                { toe}
                &quot;);
                obshto = 0;
                ch = takova;
            }
        }
    }
}
