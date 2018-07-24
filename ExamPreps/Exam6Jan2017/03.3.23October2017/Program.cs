using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// решена за многo време 90/100 
namespace _03._3._23October2017
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Sort();
            for (int i = 0; i < input.Count; i++)
            {
                string health = input[i];
                string pattern = @"[0-9\+\-*\.\/]";
                string[] results = Regex.Split(health, pattern);
                health = string.Join("", results);
                char[] healthPower = health.ToCharArray();
                int healthy = 0;
                decimal damage = 0;
                string patternDamage = @"[0-9\.?0-9]+";
                RegexOptions options = RegexOptions.Multiline;
                string healthier = input[i];
                foreach (Match m in Regex.Matches(input[i], patternDamage, options))
                {
                    int index = m.Index - 1;
                    if (index == -1)
                    {
                        index = 0;
                    }
                    if (healthier[index] == '-')
                    {
                        decimal negative = decimal.Parse(m.Value);
                        negative *= -1;
                        damage += negative;
                    }
                    else
                    {
                        damage += decimal.Parse(m.Value);
                    }
                }
                int division = 0;
                int multiplication = 0;
                char[] checks = input[i].ToCharArray();
                for (int l = 0; l < checks.Length; l++)
                {
                    if (checks[l] == '/')
                    {
                        division++;
                    }
                    if (checks[l] == '*')
                    {
                        multiplication++;
                    }
                }
                if (multiplication > 0)
                {
                    for (int m = 0; m < multiplication; m++)
                    {
                        damage *= 2;
                    }
                }
                if (division > 0)
                {
                    for (int k = 0; k < division; k++)
                    {
                        damage /= 2;
                    }
                }
                for (int j = 0; j < healthPower.Length; j++)
                {
                    healthy += healthPower[j];
                }
                Console.WriteLine($"{input[i]} - {healthy} health, {damage:f2} damage");
            }
        }
    }
}
