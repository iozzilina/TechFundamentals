using System;

namespace _02e_06_IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (b < a)
            {
                int c = a;
                a = b;
                b = c;
            }

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
