using System;

namespace _04e_17_PrintPartOfACIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = Int32.Parse(Console.ReadLine());
            int endIndex = Int32.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write((char) i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
