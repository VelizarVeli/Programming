using System;
using System.Numerics;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {

            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            decimal days = (int)(years * 365.2422);
            int hours = (int)days * 24;
            long minutes = (long)hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours:f0} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
