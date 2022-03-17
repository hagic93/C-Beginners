using System;

namespace LearnCS
{
    class Program
    {
        string name;
        string lastname;
        int SSN;

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.name = "John";
            p1.lastname = "Snow";
            p1.SSN = 123456;

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.lastname);
            Console.WriteLine(p1.SSN);

            p1.name = "Michael";

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.lastname);
            Console.WriteLine(p1.SSN);

            Program p2 = new Program();

            p1.name = "Anabela";
            p1.lastname = "Fox";
            p1.SSN = 123456;

            Console.WriteLine(p2.name);
            Console.WriteLine(p2.lastname);
            Console.WriteLine(p2.SSN);
        }
    }
}