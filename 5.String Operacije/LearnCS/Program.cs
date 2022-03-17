using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nekiString = "Ovo je kao neka malo duza recenica";

            Console.WriteLine("Duzina: " + nekiString.Length);

            Console.WriteLine("Velka slova: " + nekiString.ToUpper());

            Console.WriteLine("Mala slova: " + nekiString.ToLower());

            string drugiString = " Hack The Planet";

            string rezultat = string.Concat(nekiString, drugiString);
            Console.WriteLine(rezultat);

            string interpolacija = $"Prvi string: {nekiString} a ovo je drugi string: {drugiString}";
            Console.WriteLine(interpolacija);

            Console.WriteLine(nekiString[0]);
            Console.WriteLine(nekiString[1]);
            Console.WriteLine(nekiString[2]);
            Console.WriteLine(nekiString[3]);

            Console.WriteLine(nekiString.IndexOf("j"));
        }
    }
}