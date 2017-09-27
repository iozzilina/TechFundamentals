using System;

namespace _02e_09_CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            bool canContinue = true;

            while (canContinue)
            {
                try
                {
                    int a = Int32.Parse(input);
                    count++;
                    input = Console.ReadLine();
                }
                catch (Exception)
                {
                    canContinue = false;
                    Console.WriteLine(count);
                }
            }

        }
    }
}
