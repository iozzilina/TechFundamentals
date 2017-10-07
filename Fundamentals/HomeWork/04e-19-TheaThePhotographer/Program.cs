using System;

namespace _04e_19_TheaThePhotographer
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPictures = Int32.Parse(Console.ReadLine());
            int timeToFilter = Int32.Parse(Console.ReadLine()); //in seconds
            int filterFactor = Int32.Parse(Console.ReadLine()); //percentage of good photos
            int timeToUpload = Int32.Parse(Console.ReadLine()); //in seconds

            BigInteger totalTimeToFilter = numberOfPictures*timeToFilter;

            int numberOfGoodPictures = (int)Math.Ceiling(numberOfPictures * filterFactor /100m);
            //Console.WriteLine($"{numberOfPictures} total photos");
            //Console.WriteLine($"{numberOfGoodPictures} good photos");
            //Console.WriteLine($"{totalTimeToFilter}s time to filter");

            BigInteger totalTimeToUpload = numberOfGoodPictures*timeToUpload;
            //Console.WriteLine($"{totalTimeToUpload}s time to upload");

            BigInteger totalTime = totalTimeToFilter + totalTimeToUpload;
            BigInteger leftoverTime = totalTime;
            //BigInteger leftoverTime = 1559;
            //Console.WriteLine($"{leftoverTime}s total time");

            int days = (int)(leftoverTime / (60*60*24));
            leftoverTime = leftoverTime % (60*60*24);

            //Console.WriteLine(days + " days");
            //Console.WriteLine(leftoverTime);

            int hours = (int) leftoverTime / 3600;
            leftoverTime = leftoverTime%3600;

            //Console.WriteLine(hours + " hours");
            //Console.WriteLine(leftoverTime);

            int minutes = (int) leftoverTime / 60;
            int seconds = (int) leftoverTime % 60;

            //Console.WriteLine(minutes + " minutes");
            //Console.WriteLine(seconds + " seconds");
            
            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");
            
        }
    }
}
