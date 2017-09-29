using System;

namespace _04_02_CircleArea12precision
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * r * r:F12}");
        }
    }
}
