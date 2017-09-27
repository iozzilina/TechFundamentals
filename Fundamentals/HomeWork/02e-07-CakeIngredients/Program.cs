using System;

namespace _02e_07_CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 0;

            while(!input.Equals("Bake!"))
            {
                Console.WriteLine($"Adding ingredient {input}.");
                n += 1;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {n} ingredients.");

        }
    }
}
