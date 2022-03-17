using System;
using InternalA;

namespace LearnCS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int broj = 50;
            Console.WriteLine(broj);

            Console.WriteLine(Storage.testString);
            Console.WriteLine(Storage.nekiKarakter);

            Storage.DirectPrint();

            Console.WriteLine(BackupA.x);
            Console.WriteLine(BackupA.y);
        }

    }    
}

namespace LearnCS
{
    class Storage 
    {
        public static string testString = "Ja sam iz klase Storage";
        public static char nekiKarakter = 'A';

        public static void DirectPrint()
        {
            Console.WriteLine("Ja sam metoda iz Storage klase");
        }
    }
}

namespace InternalA
{
    class BackupA
    {
        public static int x = 5;
        public static int y = 15;
    }
}