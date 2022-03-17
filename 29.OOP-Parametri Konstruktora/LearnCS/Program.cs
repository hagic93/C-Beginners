using System;

namespace LearnCS
{
    class Program
    {
        string prodStatus;
        int prodID;
        char Warehouse;

        Program(string status, int ID, char warehouse)
        {
            prodStatus = status;
            prodID = ID;
            Warehouse = warehouse;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program("active", 12345, 'B');
            Console.WriteLine(p1.prodStatus);
            Console.WriteLine(p1.prodID);
            Console.WriteLine(p1.Warehouse);

            Program p2 = new Program("pasive", 356, 'M');
            Console.WriteLine(p2.prodStatus);
            Console.WriteLine(p2.prodID);
            Console.WriteLine(p2.Warehouse);
        }
    }
}