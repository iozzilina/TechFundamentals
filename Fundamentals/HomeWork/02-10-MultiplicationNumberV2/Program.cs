using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_10_MultiplicationNumberV2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Int32.Parse(Console.ReadLine());
            int multiplier = Int32.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                    {
                        Console.WriteLine($"{n} X {i} = {n * i}");
                    }
            }
            else
            {
                Console.WriteLine($"{n} X {multiplier} = {n*multiplier}");
            }            

        }
    }
}
