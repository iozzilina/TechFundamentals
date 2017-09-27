using System;

namespace _01e_04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = Int32.Parse(Console.ReadLine());
            int energy = Int32.Parse(Console.ReadLine()); //energy per 100 ml
            int sugar = Int32.Parse(Console.ReadLine()); // sugar per 100 ml

            double factor = volume / 100d;

            Console.WriteLine($"{volume}ml {name}:\n{energy*factor}kcal, {sugar*factor}g sugars");

        }
    }
}
