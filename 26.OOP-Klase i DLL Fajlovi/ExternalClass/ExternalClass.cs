using System;
using System.Collections.Generic;
using System.Text;
using LearnCS;

namespace LearnCS
{
    public class ExternalClass
    {
        public int x = 5;
        public string nekiString = "Otkud znam, nesto malo duze";
        public char nekiChar = 'Z';
    }
}

namespace PrintingMethods
{
    public class Printer
    {
        public static void PrinterA()
        {
            ExternalClass genericObject = new ExternalClass();

            Console.WriteLine("-------------------------------");
            Console.WriteLine(genericObject.x);
            Console.WriteLine(genericObject.nekiString);
            Console.WriteLine(genericObject.nekiChar);
        }
    }
}

namespace MultiMethods
{
    public class Multiplicator 
    {
        public static void MultiBy2()
        {
            ExternalClass gObject = new ExternalClass();
            Console.WriteLine("#########################");
            Console.WriteLine("Rezultat dupliciranja iz Multiplikator Klase");
            Console.WriteLine(gObject.x * 2);
        }
    }
}