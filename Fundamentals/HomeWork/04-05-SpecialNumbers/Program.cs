using System;

namespace _04_05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            //find all numbers in interval 1 -> n and check if the sum of their digits in 5, 7 or 11
            for (int i = 1; i <= n; i++)
            {
                //Console.WriteLine(i);
                ////find sum of digits
                int num = i;
                int sum = 0;
               

                while (num!= 0)
                {
                   
                    //Console.Write(num%10+",");
                    sum += num%10;
                    num = (int)num/10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }

                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                
                

            }

        }
    }
}
