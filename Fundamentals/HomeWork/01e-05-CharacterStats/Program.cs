using System;

namespace _01e_05_CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHealth = Int32.Parse(Console.ReadLine());
            int maxHealth = Int32.Parse(Console.ReadLine());
            int currEnergy = Int32.Parse(Console.ReadLine());
            int maxEnergy = Int32.Parse(Console.ReadLine());

            string health = '|' + new string('|', currHealth) + new string('.', maxHealth - currHealth) + '|';
            string energy = '|'+new string('|', currEnergy) + new string('.', maxEnergy - currEnergy) + '|';

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Energy: {energy}");
            
        }
    }
}
