using System;
using PrintingMethods;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ExternalClass prviObjekt = new ExternalClass();

            Console.WriteLine(prviObjekt.x);
            Console.WriteLine(prviObjekt.nekiString);
            Console.WriteLine(prviObjekt.nekiChar);

            Printer.PrinterA();
        }
    }
}