using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Natalie";
            string lastName = "Dormer";

            //Console.WriteLine(name);
            //Console.WriteLine(lastName);

            //Console.WriteLine();

            //Console.WriteLine(name);
            //Console.WriteLine(lastName);

            //Console.WriteLine(name);
            //Console.WriteLine(lastName);

            int someNumber = 50;

            Console.WriteLine(someNumber);

            char someChar = 'Z';

            Console.WriteLine(someChar);

            Console.WriteLine("Custom report: " + someChar);

            name = "XXX";

            Console.WriteLine(name);

            const int voltage = 12;

            Console.WriteLine(voltage);

            //voltage = 13; // konstantna varijabla ne moze se mjenjati jednom kad je imamo
        }
    }
}

// varijable su nazivi za kontejnere u racunaru memorijske lokacije gdje cemo staviti neki podataka
