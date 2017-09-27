using System;

namespace _01_03_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            int id = Int32.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id:D8}");
            Console.WriteLine($"Salary: {salary:F2}");

        }
    }
}
