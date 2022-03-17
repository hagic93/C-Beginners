using System;

namespace LearnCS
{
    class Program
    {
        class Storage
        {
            public string someString
            {
                get;
                set;
            }

            public int Number { get; set; }
        }

        static void Main(string[] args)
        {
            Storage p1 = new Storage();
            p1.someString = "Damo neku vrijednost";
            p1.Number = 555222;

            Console.WriteLine(p1.someString);
            Console.WriteLine(p1.Number);
        }
    }
}