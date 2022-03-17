using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pjezici = { "Perl", "Python", "Java", "JS", "C++", "C" };

            int[] brojevi = { 1, 34, 25, 100, 2, 324234, 7777, 100, 100 };

            //foreach (string x in pjezici)
            //{
            //    Console.WriteLine(x);
            //}

            foreach (int z in brojevi)
            {
                Console.WriteLine(z);
            }
        }
    }
}