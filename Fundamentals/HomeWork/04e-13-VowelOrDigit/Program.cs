using System;

namespace _04e_13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                char a = Char.Parse(input);

                switch (a)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("vowel");
                        break;

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':

                        Console.WriteLine("digit");
                        break;

                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("other");
            }
        }
    }
}

