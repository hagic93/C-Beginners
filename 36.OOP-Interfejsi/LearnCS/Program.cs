using System;

namespace LearnCS
{
    interface Prim
    {
        void primPrinter();
    }

    class Sec : Prim
    {
        public void primPrinter()
        {
            Console.WriteLine("Ova metoda je navedena u interfejsu");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sec p1 = new Sec();
        }
    }
}