using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {
        static int IstoIme(int x, int y)
        {
            return (x + y);
        }

        static string IstoIme(string x, string y)
        {
            return (x + " " + y);
        }

        static string IstoIme(char x, char y)
        {
            return (x + " " + y);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(IstoIme(10, 5));
            Console.WriteLine(IstoIme("dio jedan", "dio dva"));
            Console.WriteLine(IstoIme('R', 'Z'));
        }

    }    
}

// Metod overloading to je situacija koja ima vise implementacije iste metode koja ce radit s razlicitim tipovima podataka.