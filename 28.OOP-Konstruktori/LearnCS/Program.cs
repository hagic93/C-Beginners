using System;

namespace LearnCS
{
    class Program
    {
        string status;

        public Program()
        {
            status = "Aktivan";
        }


        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine(p1.status);

            Program p2 = new Program();
            Console.WriteLine(p2.status);

            p2.status = "Iskljuceno";
            Console.WriteLine(p2.status);
        }
    }
}