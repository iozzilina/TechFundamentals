using System;

namespace _02e_10_TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i +" ");
                }
                Console.WriteLine("");
            }


        }
    }
}
