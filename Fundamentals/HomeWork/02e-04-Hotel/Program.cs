using System;

namespace _02e_04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = Int32.Parse(Console.ReadLine());

            decimal studioPrice = 0M;
            decimal doublePrice = 0M;
            decimal suitePrice = 0M;
            decimal factor = 1.0M;
            int nightsOff = 0;

            switch (month)
            {

                case "May":
                case "October":
                    if(nightsCount > 7)
                    {
                        factor = .95M;
                    }

                    if(nightsCount>7 && month == "October")
                    {
                        nightsOff = 1;
                    }


                    studioPrice = 50M * factor * (nightsCount - nightsOff);
                    doublePrice = 65M * nightsCount;
                    suitePrice = 75M * nightsCount;

                    printRooms(studioPrice, doublePrice, suitePrice);

                    break;

                case "June":
                case "September":
                    if(nightsCount > 14)
                    {
                        factor = 0.9M;
                    }

                    if (nightsCount > 7 && month == "September")
                    {
                        nightsOff = 1;
                    }

                    studioPrice = 60M * (nightsCount - nightsOff);
                    doublePrice = 72M * factor * nightsCount;
                    suitePrice = 82M * nightsCount;

                    printRooms(studioPrice, doublePrice, suitePrice);

                    break;

                case "July":
                case "August":
                case "December":
                    if (nightsCount > 14)
                    {
                        factor = 0.85M;
                    }
                    studioPrice = 68M * nightsCount;
                    doublePrice = 77M * nightsCount;
                    suitePrice = 89M * factor * nightsCount;

                    printRooms(studioPrice, doublePrice, suitePrice);
                    break;


                default:
                    break;
            }
                                    
        }

        public static void printRooms(decimal studioPrice, decimal doublePrice, decimal suitePrice)
        {
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
            return;
        }
    }
}
