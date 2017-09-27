using System;

namespace _01e_01_DebitHardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int d = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{a:D4} {b:D4} {c:D4} {d:D4}");
        }
    }
}
