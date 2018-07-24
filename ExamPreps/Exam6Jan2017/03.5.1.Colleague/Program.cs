using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_4___Cubic_s_Messages
{
    class Program
    {
        static void Main()
        {
            List<string> validMassageList = new List<string>();

            string inputMassage = Console.ReadLine();

            Regex pattern = new Regex(@"^(\d+)([a-zA-Z]+)([^\d*]?)?(\d*)([^A-Za-z]?)$");
            // @"^([0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$"
            // @"^(\d+)([a-zA-Z]+)([^\d*]?)?(\d*)([^A-Za-z]?)$"

            while (inputMassage != "Over!")
            {
                int massageLenght = int.Parse(Console.ReadLine());

                Match getMassage = pattern.Match(inputMassage);

                if (!getMassage.Success)
                {
                    inputMassage = Console.ReadLine();
                    continue;
                }

                MatchCollection indexCollection = Regex.Matches(inputMassage, @"[\d*]");
                string getMassageText = getMassage.Groups[2].ToString();

                if (getMassageText.Length != massageLenght)
                {
                    inputMassage = Console.ReadLine();
                    continue;
                }

                StringBuilder empty = new StringBuilder();

                foreach (var item in indexCollection)
                {
                    int index = int.Parse(item.ToString());

                    if (index < massageLenght && index >= 0)
                    {

                        empty.Append(getMassageText[index]);
                    }
                    else
                    {
                        empty.Append(" ");
                    }
                }

                string result = $"{getMassageText} == {empty.ToString()}";
                validMassageList.Add(result);

                inputMassage = Console.ReadLine();
            }

            // OutPut:

            foreach (var item in validMassageList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
