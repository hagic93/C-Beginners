using System;

namespace LearnCS
{
    abstract class Prim
    {
        public abstract void primPrinter();
    }

    class Sec : Prim
    {
        public override void primPrinter()
        {
            Console.WriteLine("Sada tek mozemo da upotrijebimo ovu metodu");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sec s1 = new Sec();

            s1.primPrinter();
        }
    }
}