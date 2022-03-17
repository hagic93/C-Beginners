using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#---------------------------------#");

            Console.WriteLine("Unesite prvi broj");
            string prviBroj = Console.ReadLine();
            float pBroj = Convert.ToInt32(prviBroj);

            Console.WriteLine("Unesite drugi broj");
            string drugiBroj = Console.ReadLine();
            float dBroj = Convert.ToInt32(drugiBroj);

            Console.WriteLine("#---------------------------------#");

            Console.WriteLine("Tip podatka: " + pBroj.GetType() + " vrijednost: " + pBroj);
            Console.WriteLine("Tip podatka: " + dBroj.GetType() + " vrijednost: " + dBroj);

            Console.WriteLine("Sabiranje: " + (pBroj + dBroj));
            Console.WriteLine("Oduzmanje: " + (pBroj - dBroj));
            Console.WriteLine("Mnozenje: " + (pBroj * dBroj));
            Console.WriteLine("Djeljenje: " + (pBroj / dBroj));
            Console.WriteLine("Modulus (ostatak djeljenja): " + (pBroj % dBroj));


        }
    }
}