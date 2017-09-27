using System;

namespace _02e_03_RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = Int32.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = string.Empty;
            decimal price = 0;

            //determine hall size
            if (peopleCount > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (peopleCount <= 50)
            {
                hall += "Small Hall";
                price += 2500M;
            }
            else if (peopleCount<=100)
            {
                hall += "Terrace";
                price += 5000M;
            }
            else if (peopleCount <= 120)
            {
                hall += "Great Hall";
                price += 7500M;
            }           

            // set the price based on package
            switch (package)
            {
                case "Normal":
                    price += 500M;
                    price *= .95M;
                    break;
                case "Gold":
                    price += 750M;
                    price *= .9M;
                    break;
                case "Platinum":
                    price += 1000M;
                    price *= .85M;
                    break;
                default:
                    break;
            }

            Console.WriteLine( $"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {(price/peopleCount):F2}$");

        }
    }
}
