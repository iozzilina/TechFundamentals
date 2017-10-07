using System;

namespace _04e_15_FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck= Int32.Parse(Console.ReadLine());

            for (int i = 2; i <= numberToCheck; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
            
        }
    }
}
