using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int jezik = 2;

            switch (jezik)
            {
                case 1:
                    Console.WriteLine("Perl");
                    break;
                case 2:
                    Console.WriteLine("Python");
                    break;
                case 3:
                    Console.WriteLine("C++");
                    break;
                case 4:
                    Console.WriteLine("Java");
                    break;
                case 5:
                    Console.WriteLine("PHP");
                    break;
                default:
                    Console.WriteLine("Nepoznat jezik");
                    break;
            }

        }
    }
}