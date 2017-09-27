using System;

namespace _02e_01_ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();
            string drink = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    drink += "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink += "Coffee";
                    break;
                case "SoftUni Student":
                    drink += "Beer";
                    break;
               default:
                    drink += "Tea";
                    break;
            }

            Console.WriteLine(drink);

        }
    }
}
