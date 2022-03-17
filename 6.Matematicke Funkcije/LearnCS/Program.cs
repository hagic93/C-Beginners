using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            float pBroj = 10.56F;
            float dBroj = 12.20F;
            int tBroj = 9;

            Console.WriteLine("Max: " + Math.Max(pBroj, dBroj));
            Console.WriteLine("Min: " + Math.Min(pBroj, dBroj));
            Console.WriteLine("Korijen: " + Math.Sqrt(tBroj));
            Console.WriteLine("Apsolutna vrijednost: " + Math.Abs(-45));
            Console.WriteLine("Zaokruzivanje: " + Math.Round(5.55));
            Console.WriteLine("Zaokruzivanje: " + Math.Round(5.2));
        }
    }
}