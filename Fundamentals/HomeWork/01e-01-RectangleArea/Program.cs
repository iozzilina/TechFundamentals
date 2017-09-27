using System;

namespace _01e_01_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal area = a * b;

            Console.WriteLine($"{area:F2}");
        }
    }
}
