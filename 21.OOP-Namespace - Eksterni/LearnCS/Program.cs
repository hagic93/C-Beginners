﻿using System;
using DirectPrinter;

namespace LearnCS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ja sam iz Glavnog Fajla");

            ExternalSource.ExternalMethod();

            Console.WriteLine(ExternalSource.x);

            DirectA.DirectPrintA();
            DirectB.DirectPrintB();
        }

    }    
}