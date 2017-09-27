using System;

namespace _02e_02_ChooseADrinkV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int qty = Int32.Parse(Console.ReadLine());
            
            string drink = string.Empty;
            decimal price = 0M;

            switch (profession)
            {
                case "Athlete":
                    drink += "Water";
                    price = .7M;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink += "Coffee";
                    price = 1.00M;
                    break;
                case "SoftUni Student":
                    drink += "Beer";
                    price = 1.70M;
                    break;
                default:
                    drink += "Tea";
                    price = 1.20M;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {qty*price:F2}.");

        }
    }
}
