using System;

namespace _15.BalancedBrackets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            bool first = true;
            for (int i = 0; i < n; i++)
            {
                string stringche = Console.ReadLine();
                if (stringche == ")" && index == 0)
                {
                    first = false;
                }
                if (stringche == ")")
                {
                    index--;
                }
               if (stringche == "(")
                {
                    index++;
                }
            }
            if (index == 0 && first)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
