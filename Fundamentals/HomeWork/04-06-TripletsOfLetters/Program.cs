﻿using System;

namespace _04_06_TripletsOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine($"{(char)('a'+i)}{(char)('a' + j)}{(char)('a' + k)}");
                    }
                }
            }
        }
    }
}
