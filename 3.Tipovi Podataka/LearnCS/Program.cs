using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            float fNumber = 5.521F;
            double dNumber = 10.564564564D;
            long lNumber = 5549635418351865189L;

            string someString = "Bilo sta";
            char zChar = 'Z';

            Console.WriteLine(number);
            Console.WriteLine(fNumber);
            Console.WriteLine(dNumber);
            Console.WriteLine(lNumber);

            Console.WriteLine(someString);
            Console.WriteLine(zChar);

            double sciNumber = 15.36E23D; //15.36 * 10 ^ 23

            Console.WriteLine(sciNumber);

            Console.WriteLine("Value: " + number + " Datatype: " + number.GetType());
            Console.WriteLine("Value: " + fNumber + " Datatype: " + fNumber.GetType());
            Console.WriteLine("Value: " + dNumber + " Datatype: " + dNumber.GetType());
            Console.WriteLine("Value: " + someString + " Datatype: " + lNumber.GetType());
            Console.WriteLine("Value: " + zChar + " Datatype: " + zChar.GetType());
            Console.WriteLine("Value: " + sciNumber + " Datatype: " + sciNumber.GetType());

        }
    }
}