using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_BackIn30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = Int32.Parse(Console.ReadLine());
            int minutes = Int32.Parse(Console.ReadLine());

            int finalHour = hour+0;
            int finalMinutes = minutes + 30;

            if (finalMinutes >= 60)
            {
                finalMinutes -=60;
                finalHour += 1;
            }

            if (finalHour > 23)
            {
                finalHour = 0;
            }

            Console.WriteLine($"{finalHour}:{finalMinutes:D2}");
            
        }
    }
}
