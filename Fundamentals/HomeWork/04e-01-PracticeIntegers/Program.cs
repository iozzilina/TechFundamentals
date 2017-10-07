using System;

namespace _04e_01_PracticeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = SByte.Parse(Console.ReadLine());
            byte b = Byte.Parse(Console.ReadLine());
            short c = short.Parse(Console.ReadLine());
            ushort d = ushort.Parse(Console.ReadLine());
            uint e = UInt32.Parse(Console.ReadLine());
            int f = Int32.Parse(Console.ReadLine());
            long g = Int64.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
