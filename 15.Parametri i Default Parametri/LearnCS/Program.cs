using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {

        static void Digitron(double x, double y) 
        {
            Console.WriteLine("Zbir: " + (x + y));
            Console.WriteLine("Oduzmanje: " + (x - y));
            Console.WriteLine("Mnozenje: " + (x * y));
            Console.WriteLine("Djeljenje: " + (x / y));
        }

        static void Lica(string x, string y) 
        {
            //Console.WriteLine("Ime: " + x);
            //Console.WriteLine("Prezime: " + y);
            string linija = x + " " + y;
            Console.WriteLine(linija);
        }

        static void DefDef(int x = 10)
        {
            Console.WriteLine(x * 2);
        }

        static void Main(string[] args)
        {
            //Digitron(10.50, 5.25);
            //Lica("Perro", "Bjadjoti");
            DefDef();
            DefDef(100);
        }

    }    
}