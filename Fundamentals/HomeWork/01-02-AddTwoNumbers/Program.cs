using System;

namespace _01_02_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int sum = Int32.Parse(a) + Int32.Parse(b);

            Console.WriteLine("{0} + {1} = {2}",a,b,sum);

        }
    }
}
