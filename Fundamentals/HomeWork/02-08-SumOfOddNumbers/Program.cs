using System;

namespace _02_08_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Int32.Parse(Console.ReadLine());
            int sum = 0;
            int currNum = 1;

            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine(currNum);
                sum += currNum;
                currNum += 2;                
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
