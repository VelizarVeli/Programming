using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main()
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            int uploadTimePerFilteredPic = int.Parse(Console.ReadLine());

            var filteringTime = (long)numberOfPictures * filterTime;
            var useful = (long)Math.Ceiling(numberOfPictures * (percentage / 100d));
            var uploading = uploadTimePerFilteredPic * useful;
            var totalTime = filteringTime + uploading;

            var span = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine(span.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
