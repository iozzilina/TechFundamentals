using System;

namespace _02_12_NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int n = Int32.Parse(input);
                Console.WriteLine("It is a number.");
                return;         
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
                return;
            }         


        }
    }
}
