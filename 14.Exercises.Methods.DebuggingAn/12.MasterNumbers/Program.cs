using System;

namespace _12.MasterNumbers
{
    class Program
    {
        static bool IsPalindrome(string value)
        {

            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }

        }

        static bool SumOfDigits(int num)
        {
            bool checkOf7 = false;
            string numstr = num.ToString();
            int sumOf7 = 0;
            int sum = 0;
            for (int i = 0; i < numstr.Length; i++)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                sumOf7 = num;
                checkOf7 = true;
            }
            return checkOf7;
        }
        static bool ContainsEvenDigit(int num)
        {
            bool even = false;
            string numstr = num.ToString();
            for (int i = 0; i < numstr.Length; i++)
            {
                int check = num % 10;
                num /= 10;
                if (check % 2 == 0)
                {
                    even = true;
                    break;
                }
            }
            return even;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 232; i <= number; i++)
            {
                bool check1 = false;
                bool check2 = false;
                bool check3 = false;
                check1 = IsPalindrome(i.ToString());
                if (check1)
                {
                    check2 = SumOfDigits(i);
                    if (check2)
                    {
                        check3 = ContainsEvenDigit(i);
                    }
                }
                if (check1 && check2 && check3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
