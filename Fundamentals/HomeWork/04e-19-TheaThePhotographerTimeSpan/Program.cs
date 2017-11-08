using System;
using System.Numerics;

namespace _04e_19_TheaThePhotographerTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = Int32.Parse(Console.ReadLine());
            int timeToFilter = Int32.Parse(Console.ReadLine()); //in seconds
            int filterFactor = Int32.Parse(Console.ReadLine()); //percentage of good photos
            int timeToUpload = Int32.Parse(Console.ReadLine()); //in seconds
            
            int numberOfGoodPictures = (int)Math.Ceiling(numberOfPictures * filterFactor / 100m);
            
            TimeSpan time = new TimeSpan(0,0,0,numberOfPictures * timeToFilter + numberOfGoodPictures * timeToUpload);

            Console.WriteLine(time.ToString("d:hh:mm:ss"));
        }
    }
}
