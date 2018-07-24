using System;

namespace _05.ForeignLanguages
{
    class Program
    {
        static void Main()
        {
            string language = Console.ReadLine().ToLower();

            switch (language)
            {
                case "england":
                    
                case "usa":
                    Console.WriteLine("English");
                    break;
                case "spain":
                   
                case "argentina":
                    
                case "mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
