using System;

namespace _02_01_Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if(grade >= 3.00d)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                return;
            }

        }
    }
}
