﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02e_08_CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Int32.Parse(Console.ReadLine());
            int calories = 0;

            
            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;

                    default:
                        break;

                }

            }

            Console.WriteLine($"Total calories: {calories}");
            

        }
    }
}
