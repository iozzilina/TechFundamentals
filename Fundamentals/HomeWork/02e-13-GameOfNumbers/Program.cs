using System;

namespace _02e_13_GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int magicSum = Int32.Parse(Console.ReadLine());
            int combinationCount = 0;
            int foundA = 0;
            int foundB = 0;
            bool found = false;

            for (int dec = a; dec <= b; dec++)
            {
                for (int ed = a; ed <= b; ed++)
                {
                    //Console.WriteLine($"{dec}+{ed}");
                    combinationCount++;

                    if (dec + ed == magicSum)
                    {
                        found = true;
                        foundA = dec;
                        foundB = ed;
                        //Console.WriteLine($"Number found! {foundA} + {foundB} = {magicSum}");
                    }
                }
            }

            if(found)
            {
                Console.WriteLine($"Number found! {foundA} + {foundB} = {magicSum}");
            }
            else
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicSum}");
            }
            
        }
    }
}
