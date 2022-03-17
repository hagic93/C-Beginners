using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {
        static int GetStuff()
        {
            int x = 10;
            int y = 20;
            int z = (x + y);

            return z;
        }

        static int Puta2()
        {
            int rezultat = (GetStuff() * 2);

            return rezultat;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetStuff());
            Console.WriteLine(Puta2());
        }

    }    
}