using System;


namespace _04e_16_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());

            double eps = 0.000001;
            bool areEqual = false;

            if (Math.Abs(a - b) < eps)
            {
                areEqual = true;
            }

            Console.WriteLine(areEqual);

        }
    }
}
