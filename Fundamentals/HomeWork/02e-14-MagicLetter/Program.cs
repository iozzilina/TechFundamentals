using System;

namespace _02e_14_MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = Char.Parse(Console.ReadLine());
            char second = Char.Parse(Console.ReadLine());
            char skip = Char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        string result = $"{i}{j}{k}";
                        if (!result.Contains(skip.ToString()))
                        {
                            Console.Write(result+" ");
                        }
                    }
                }
            }

        }
    }
}
