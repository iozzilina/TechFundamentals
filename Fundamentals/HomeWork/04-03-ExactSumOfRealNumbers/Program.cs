using System;

namespace _04_03_ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEntries = Int32.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 0; i < numberOfEntries; i++)
            {
                
                sum+=Decimal.Parse(Console.ReadLine());
            }

           Console.WriteLine(sum);


        }
    }
}
