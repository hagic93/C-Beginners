using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (25 > 50)
            //{
            //    Console.WriteLine("25 je vece od 50");
            //}
            //if (25 < 50)
            //{
            //    Console.WriteLine("25 je manje od 50");
            //}
            //if (25 == 25)
            //{
            //    Console.WriteLine("25 je stvarno jednako 25");
            //}

            int x = 25;
            int y = 50;

            if (x < y)
            {
                Console.WriteLine(x + " je manje od " + y);
            }
            else if (x > y) 
            {
                Console.WriteLine(x + " je vece od " + y);
            }
            else
            {
                Console.WriteLine("Unijeti brojevi su jednaki");
            }
        }
    }
}