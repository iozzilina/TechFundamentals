using System;

namespace _04e_14_IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());

            Console.WriteLine((Convert.ToString(input, 16)).ToUpper());
            Console.WriteLine((Convert.ToString(input, 2)).ToUpper());
            
        }
    }
}
