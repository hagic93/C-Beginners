using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtermalClass prviObjekt = new ExtermalClass();

            Console.WriteLine(prviObjekt.x);
            Console.WriteLine(prviObjekt.nekiString);
            Console.WriteLine(prviObjekt.nekiChar);

            Console.WriteLine("---------------------------");

            ExtermalClass stotiObjekt = new ExtermalClass();

            Console.WriteLine(stotiObjekt.x);
            Console.WriteLine(stotiObjekt.nekiString);
            Console.WriteLine(stotiObjekt.nekiChar);

        }
    }
}