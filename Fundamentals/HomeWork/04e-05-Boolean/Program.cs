using System;

namespace _04e_05_Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool a = Convert.ToBoolean(input);

            if (a)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
