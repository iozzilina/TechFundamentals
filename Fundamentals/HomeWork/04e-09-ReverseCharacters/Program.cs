﻿using System;

namespace _04e_09_ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Char.Parse(Console.ReadLine());
            char b = Char.Parse(Console.ReadLine());
            char c = Char.Parse(Console.ReadLine());

            Console.WriteLine($"{c}{b}{a}");
        }
    }
}
