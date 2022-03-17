using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {

        static void Stampanje()
        {
            Console.WriteLine("Ja sam tekst iz stampane Metode");
        }

        static void Multiplikator()
        {
            Stampanje();
            Stampanje();
            Stampanje();
            Stampanje();
            Stampanje();
        }

        static void Main(string[] args)
        {
            //Stampanje();
            //Multiplikator();
            Zbrajanje();
        }

        static void Zbrajanje() 
        {
            int x = 5;
            int y = 10;
            int rezultat = x + y;

            Console.WriteLine("Rezultat: " + rezultat);
        }

    }    
}