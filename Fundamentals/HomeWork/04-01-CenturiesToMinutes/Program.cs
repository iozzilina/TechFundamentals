using System;

namespace _04_01_CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");

            int centuries = Int32.Parse(Console.ReadLine());

            int years = centuries*100;
            int days = (int) (years*365.2422);
            int hours = 24*days;
            int minutes = 60*hours;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
