using System;

namespace _04e_18_DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length > 20)
            {
                Console.WriteLine($"{input} can't fit in any type");
                return;
            }

            string result = $"{input} can fit in:" + Environment.NewLine;

            sbyte a;
            byte b;
            short c;
            ushort d;
            int e;
            uint f;
            long g;

            if (SByte.TryParse(input, out a))
            {
                 result += "* sbyte" + Environment.NewLine;
            }
            if (Byte.TryParse(input, out b))
            {
                result += "* byte" + Environment.NewLine;
            }
            if (short.TryParse(input, out c))
            {
                result += "* short" + Environment.NewLine;
            }
            if (ushort.TryParse(input, out d))
            {
                result += "* ushort" + Environment.NewLine;
            }
            if (int.TryParse(input, out e))
            {
                result += "* int" + Environment.NewLine;
            }
            if (uint.TryParse(input, out f))
            {
                result += "* uint" + Environment.NewLine;
            }
            if (long.TryParse(input, out g))
            {
                result += "* long" + Environment.NewLine;
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
                return;
            }

            //sbyte: 8 bits, range from -128 - 127
            //short: 16 bits, range from -32,768 - 32,767
            //int : 32 bits, range from -2,147,483,648 - 2,147,483,647
            //long : 64 bits, range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            //byte : 8 bits, range from 0 - 255
            //ushort : 16 bits, range from 0 - 65,535
            //uint : 32 bits, range from 0 - 4,294,967,295
            //ulong : 64 bits, range from 0 - 18,446,744,073,709,551,615

            Console.WriteLine(result);
            
        }
    }
}
