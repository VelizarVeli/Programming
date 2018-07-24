using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// решена с подсказка 100/100
namespace _01._4.Exam11September2016
{
    class Program
    {
        static void Main()
        {
            long amountOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long fFactor = long.Parse(Console.ReadLine());
            long timeForUploading = long.Parse(Console.ReadLine());

            var usefulPics = (int)Math.Ceiling(amountOfPictures * (fFactor / 100.00));
            long totalFilterTime = filterTime * amountOfPictures;
            long totalUploadTime = timeForUploading * usefulPics;
            long totalTime = totalUploadTime + totalFilterTime;

            long seconds = totalTime % 60;
            totalTime = totalTime - seconds;
            long hours = totalTime / 3600;
            long minutes = totalTime / 60 - hours * 60;
            long days = hours / 24;
            hours = totalTime / 3600 - days * 24;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
