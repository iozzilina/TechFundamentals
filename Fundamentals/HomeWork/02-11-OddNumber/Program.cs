using System;

namespace _02_11_OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            while (n % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                n = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(n)}");
            

        }
    }
}
