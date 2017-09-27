using System;

namespace _02e_15_NeighbourWars
{
    using System.Security.Cryptography;

    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = Int32.Parse(Console.ReadLine());
            int damageGosho = Int32.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;
            int turn = 0;

            while (healthPesho > 0 && healthGosho > 0)
            {
                turn++;
                if (turn%2 != 0)
                {
                    healthGosho -= damagePesho;
                    if (healthGosho < 1)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else
                {
                    healthPesho -= damageGosho;
                    if (healthPesho < 1)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }

                if (turn%3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }

            }

            if (healthPesho < 1)
            {
                Console.WriteLine($"Gosho won in {turn}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {turn}th round.");
            }


        }
    }
}
