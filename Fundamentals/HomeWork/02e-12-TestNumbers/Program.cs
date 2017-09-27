using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02e_12_TestNumbers
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int maxSum = Int32.Parse(Console.ReadLine());
            int combinationCount = 0;
            int sum = 0;


            for (int dec = a; dec > 0; dec--)
            {
                for (int ed = 1; ed <= b; ed++)
                {
                    int curr = dec*ed*3;
                    //Console.WriteLine(curr);

                    sum += curr;
                    combinationCount++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{combinationCount} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }

                }
            }

            Console.WriteLine($"{combinationCount} combinations");
            Console.WriteLine($"Sum: {sum}");
        }

    }
}




