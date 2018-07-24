using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
// решена за време 1 час 25 минути 90/100 
// малка поправка 100/100 ако не броя част от стринга с 0, броят се само символите които ще отпечатам за уникални.

namespace _03._4.Exam_PreparationIII
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string splitDigit = @"[0-9]";
            string[] symbolsOne = Regex.Split(input, splitDigit);

            string[] symbols = symbolsOne.Where(s => s != String.Empty).ToArray();

            string[] numbersOne = Regex.Split(input, @"\D+");
            string[] numbers = numbersOne.Where(x => x != String.Empty).ToArray();
           
            var theLastBuilder = new StringBuilder(2000);
            var counterin = new StringBuilder(1000);
            for (int n = 0; n < symbols.Length; n++)
            {
                
                string curr = symbols[n].ToUpper();
                counterin.Append(curr);
            }
            
            for (int i = 0; i < symbols.Length; i++)
            {
                int currentNum = int.Parse(numbers[i]);
                string currentString = "";
                for (int j = 0; j < currentNum; j++)
                {
                    currentString += symbols[i].ToUpper();
                }
                theLastBuilder.Append(currentString);
            }
            var count = theLastBuilder.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(theLastBuilder);
        }
    }
}
