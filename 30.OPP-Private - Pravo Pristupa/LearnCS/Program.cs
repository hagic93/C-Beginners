using System;

namespace LearnCS
{
    class Program
    {
        class Storage
        {
            private string somethingString = "Neka malo duza recenica";
            private int prviID = 5;

            public int MnozenjeSa2()
            {
                return prviID;
            }

            public string Konkatenacija()
            {
                return somethingString;
            }
        }

        static void Main(string[] args)
        {
            Storage p1 = new Storage();

            Console.WriteLine(p1.MnozenjeSa2());
            Console.WriteLine(p1.Konkatenacija());
        }
    }
}