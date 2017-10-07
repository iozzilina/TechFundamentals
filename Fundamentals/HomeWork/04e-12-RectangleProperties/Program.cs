using System;

namespace _04e_12_RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = Double.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(width*width + height*height);

            Console.WriteLine((width + height)*2.0);
            Console.WriteLine(width*height);
            Console.WriteLine(diagonal);

        }
    }
}
