using System;

namespace _04e_08_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            char gender = Char.Parse(Console.ReadLine());
            string personalId = Console.ReadLine();
            string employeeId = Console.ReadLine();

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalId}");
            Console.WriteLine($"Unique Employee number: {employeeId}");

        }
    }
}
