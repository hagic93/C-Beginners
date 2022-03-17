using System;
using System.Linq;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 20)
            {
                if (x == 10)
                {
                    x++;
                    continue;
                }
                Console.WriteLine(x);
                x++;
            }

            //int x = 0;

            //while (x < 20)
            //{
            //    Console.WriteLine(x);
            //    x++;

            //    if (x == 10)
            //    {
            //        break;
            //    }
            //}

            //for (int x = 0; x < 20; x++)
            //{
            //    if (x == 11)
            //    {
            //        //break;
            //        continue;
            //    }
            //    Console.WriteLine(x);
            //}
        }
    }    
}