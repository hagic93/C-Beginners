using System;

namespace LearnCS
{
    class Prim
    {
        public string someString = "Ja sam iz primarne klase";

        public void primPrinter()
        {
            Console.WriteLine("Ja sam iz primPrinter Metode, iz Primarne Klase");
        }
    }

    class Sec : Prim
    {
        public string secString = "Ja sam iz sekundarne klase";

        public void secMethod()
        {
            Console.WriteLine("Ja sam iz sekundarne metode");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prim p1 = new Prim();
            Console.WriteLine(p1.someString);
            p1.primPrinter();

            Sec s1 = new Sec();
            Console.WriteLine(s1.secString);
            Console.WriteLine(s1.someString);
            s1.primPrinter();
            s1.secMethod();
        }
    }
}