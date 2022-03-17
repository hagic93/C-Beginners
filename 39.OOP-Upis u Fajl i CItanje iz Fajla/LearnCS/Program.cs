using System;
using System.IO;

namespace LearnCS
{
    class Program
    {

        static void Main(string[] args)
        {
            //string toFile = "Ovo ce zavrsiti u eksternom txt fajlu";
            //File.WriteAllText("external.txt", toFile);

            string fromFile = File.ReadAllText("external.txt");
            Console.WriteLine(fromFile);
        }
    }
}