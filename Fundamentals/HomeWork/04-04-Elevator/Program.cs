using System;

namespace _04_05_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = Int32.Parse(Console.ReadLine());
            int elevatorCapacity = Int32.Parse(Console.ReadLine());

            int runs = (int)Math.Ceiling((double)numberOfPeople / elevatorCapacity);

            Console.WriteLine(runs);

        }
    }
}
