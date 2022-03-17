using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pjezici = { "Perl", "Python", "Java", "JS", "C++", "C" };

            int[] brojevi = { 1, 34, 25, 100, 2, 324234, 7777, 100, 100 };

            pjezici[0] = "Prolog";
            pjezici[1] = "Lisp";

            Console.WriteLine("Broj elemenata:" + pjezici.Length);

            for (int x = 0; x < pjezici.Length; x++)
            {
                Console.WriteLine("Pozicija: " + x + "Vrijednost: " + pjezici[x]);
            }

            Array.Sort(brojevi);

            foreach (var c in brojevi)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Total: " + brojevi.Sum());
            Console.WriteLine("Max: " + brojevi.Max());
            Console.WriteLine("Min: " + brojevi.Min());

            //foreach (string x in pjezici)
            //{
            //    Console.WriteLine(x);
            //}
        }
    }    
}