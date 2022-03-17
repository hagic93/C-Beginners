using System;

namespace LearnCS
{
    class Prim
    {
        public virtual void istoIme()
        {
            Console.WriteLine("istoIme, ali iz primarne klase");
        }
    }

    class Sec : Prim
    {
        public override void istoIme()
        {
            Console.WriteLine("istoIme, ali iz sekundarne klase, neke malo komplikovanije operacije");
        }
    }

    class Ter : Prim
    {
        public override void istoIme()
        {
            Console.WriteLine("istoIme, ali iz tercijarne klase, bas komplikovane operacije");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prim p1 = new Prim();
            Prim p2 = new Sec();
            Prim p3 = new Ter();

            p1.istoIme();
            p2.istoIme();
            p3.istoIme();
        }
    }
}