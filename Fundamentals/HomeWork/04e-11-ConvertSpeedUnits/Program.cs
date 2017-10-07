using System;

namespace _04e_11_ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = Int32.Parse(Console.ReadLine());

            float distanceInMiles = distanceInMeters/1609f;

            sbyte hours = SByte.Parse(Console.ReadLine());
            sbyte minutes = SByte.Parse(Console.ReadLine());
            sbyte seconds = SByte.Parse(Console.ReadLine());

            float totalTimeInHours = hours + minutes/60F + seconds/3600F;
            float totalTimeInSeconds = hours*3600F + minutes*60F + seconds;

            Console.WriteLine(distanceInMeters/totalTimeInSeconds);
            Console.WriteLine((distanceInMeters / 1000f) / totalTimeInHours);
            Console.WriteLine((distanceInMiles) / totalTimeInHours);
           

        }
    }
}

