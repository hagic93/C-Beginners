using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[] karakteri = { 'A', 'B', 'C' };

            try
            {
                Console.WriteLine(karakteri[100]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Doslo je do greske - pogresan index");
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("Ja cu se izvrsiti bez obzira ima li greske ili nema");
                Console.WriteLine("Ja uvijek radim");
            }
        }

    }    
}

 