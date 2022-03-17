using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {
        static void PromjenaRedoslijeda(int x1, string x2, char x3)
        {
            Console.WriteLine("Integer: " + x1);
            Console.WriteLine("String: " + x2);
            Console.WriteLine("Character: " + x3);
        }

        static void Normalna(int x, int y, int z)
        {
            Console.WriteLine("Prvi: " + x);
            Console.WriteLine("Drugi: " + y);
            Console.WriteLine("Treci: " + z);
        }
      
        static void Main(string[] args)
        {
            //Normalna(1, 4, 8);
            //PromjenaRedoslijeda(5, "test string", 'B');
            PromjenaRedoslijeda(x3: 'Z', x1: 5000, x2: "neka vrijednost bla bla");

        }

    }    
}