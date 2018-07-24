using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumBigNumbers
{
    public static void Main()
    {
        string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
        string secondNumber = Console.ReadLine().TrimStart(new char[] { '0' });

        if (firstNumber.Length > secondNumber.Length)
        {
            secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
        }
        else
        {
            firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
        }

        byte sum = 0;
        byte numberInMind = 0;
        byte remainder = 0;
        StringBuilder result = new StringBuilder();

        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            sum = (byte)(byte.Parse(firstNumber[i].ToString()) + byte.Parse(secondNumber[i].ToString()) + numberInMind);
            numberInMind = (byte)(sum / 10);
            remainder = (byte)(sum % 10);
            result.Append(remainder);
            if (i == 0 && numberInMind != 0)
            {
                result.Append(numberInMind);
            }
        }

        char[] resultToChar = result.ToString().ToCharArray();
        Array.Reverse(resultToChar);
        Console.WriteLine(new string(resultToChar));
    }
}