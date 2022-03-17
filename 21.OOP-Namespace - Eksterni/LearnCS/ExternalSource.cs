using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCS
{
    class ExternalSource
    {
        public static void ExternalMethod()
        {
            Console.WriteLine("Ja sam tekst iz Eksterne Metode");
        }

        public static int x = 100;
    }
}

namespace DirectPrinter
{
    class DirectA
    {
        public static void DirectPrintA() 
        {
            Console.WriteLine("Linija iz DirectA klase");
        }
    }
    class DirectB
    {
        public static void DirectPrintB()
        {
            Console.WriteLine("Linija iz DirectB klase");
        }
    }

}