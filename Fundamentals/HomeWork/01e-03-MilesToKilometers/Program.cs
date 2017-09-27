using System;

namespace _01e_03_MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal conversion = 1.60934M;

            Console.WriteLine($"{miles*conversion:F2}");

        }
    }
}
