using System;

namespace _12.BeerKegs
{
    class Program
    {
        static void Main()
        {
            byte lines = byte.Parse(Console.ReadLine());
            double currVolume = 0;
            string curModel = "";
            for (int i = 0; i < lines; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                var volume = Math.PI * r * r * height;
                if (volume > currVolume)
                {
                    currVolume = volume;
                    curModel = model;
                }
            }
            Console.WriteLine(curModel);
        }
    }
}
