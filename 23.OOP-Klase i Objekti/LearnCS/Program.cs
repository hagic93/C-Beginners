using System;
using DirectPrinter;

namespace LearnCS
{
    class Program
    {
        string x = "Genericka vrijednost za x";
        string y = "Genericka vrijednost za y";

        static void Outsider() 
        {
            Program generic = new Program();
            Console.WriteLine("##################");
            Console.WriteLine(generic.x);
            Console.WriteLine(generic.y);
        }
        
        static void Main(string[] args)
        {
            Program prviObjekt = new Program();

            Console.WriteLine(prviObjekt.x);
            Console.WriteLine(prviObjekt.y);

            Program drugiObjekt = new Program();

            Console.WriteLine(drugiObjekt.x);
            Console.WriteLine(drugiObjekt.y);

            Outsider();
        }

    }
}