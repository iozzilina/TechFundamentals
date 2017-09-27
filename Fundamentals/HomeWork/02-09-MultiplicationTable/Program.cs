using System;

namespace _02_09_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }

        }
    }
}
