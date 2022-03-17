using System;

namespace LearnCS
{
    class Program
    {
        class Storage
        {
            private string someString;
            public string MitmString
            {
                set { someString = value; }
                get { return someString; }
            }

            private int Number;
            public int MitmNumber
            {
                set { Number = value; }
                get { return Number; }
            }
        }

        static void Main(string[] args)
        {
            Storage p1 = new Storage();
            p1.MitmString = "Neka vrijednost";
            Console.WriteLine(p1.MitmString);

            Storage p2 = new Storage();
            p2.MitmNumber = 123456;
            Console.WriteLine(p2.MitmNumber);
        }
    }
}