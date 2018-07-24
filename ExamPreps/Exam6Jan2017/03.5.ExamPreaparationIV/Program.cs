using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._5.ExamPreaparationIV
{
    class Program
    {
        static void Main()
        {
            string input = "";
            while (true)
            {
                string allNums = String.Empty;

                input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                string number = "";
                string word = "";
                string theWord = "";
                bool checky = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        number += input[i];
                    }
                    else
                    {
                        if (Char.IsDigit(input[i + 1]))
                        {
                            checky = false;
                            break;
                        }
                        word = input.Substring(i, input.Length - i);
                        break;
                    }
                }
                if (checky)
                {
                    string secondDigits = "";
                    string digits2 = String.Empty;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (!Char.IsLetter(word[j]))
                        {
                            theWord = word.Substring(0, j);
                            secondDigits = word.Substring(j, word.Length - j);
                            for (int a = 0; a < secondDigits.Length; a++)
                            {
                                if (Char.IsLetter(secondDigits[a]))
                                {
                                    checky = false;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    for (int g = 0; g < secondDigits.Length; g++)
                    {
                        if (Char.IsDigit(secondDigits[g]))
                        {
                            digits2 += secondDigits[g];
                        }
                    }

                    allNums = number + digits2;

                }

                int input2 = int.Parse(Console.ReadLine());
                if (theWord.Length != input2)
                {
                    continue;
                }
                //verification code
                string verificationCode = "";
                for (int c = 0; c < allNums.Length; c++)
                {
                    int index = allNums[c]-48;
                    if (index < theWord.Length)
                    {
                        verificationCode += theWord[index];
                    }
                    else
                    {
                        verificationCode += " ";
                    }
                }
                if (checky)
                {
                    Console.WriteLine($"{theWord} == {verificationCode}");
                }
            }
        }
    }
}
