using System;

namespace _02e_05_WordsInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (a.EndsWith("y"))
            {
                Console.WriteLine(a.Remove(a.Length-1)+"ies");
            }
            else if (a.EndsWith("o") || a.EndsWith("s")|| a.EndsWith("x") ||
                     a.EndsWith("z") || a.EndsWith("ch") || a.EndsWith("sh"))
            {
                    Console.WriteLine(a + "es");
            }

            else
            {
                Console.WriteLine(a + "s");
            }
            
        }
    }
}
