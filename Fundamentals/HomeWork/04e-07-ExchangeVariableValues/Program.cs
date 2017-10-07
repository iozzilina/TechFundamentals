using System;

namespace _04e_07_ExchangeVariableValues
{
    using System.Linq.Expressions;
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Printout("Before", a, b);

            int c = a*1;

            a = b*1;

            b = c*1;

            Printout("After", a, b);


        }

        public static void Printout(string status, int a, int b)
        {
            Console.WriteLine(status+":");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
