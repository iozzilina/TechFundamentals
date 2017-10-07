using System;

namespace _04e_04_VariablesInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            Console.WriteLine($"{Convert.ToInt32(n,16)}");

        }
    }
}
