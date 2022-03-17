using System;

namespace LearnCS
{
    class Program
    {
        interface IBackupA
        {
            void BackupA();
        }

        interface IBackupB
        {
            void BaskupB();
        }

        class Sec : IBackupA, IBackupB
        {
            public void BackupA()
            {
                Console.WriteLine("Metoda za Backup servera A");
            }

            public void BaskupB()
            {
                Console.WriteLine("Metoda za Backup servera B");
            }
        }

        static void Main(string[] args)
        {
            Sec p1 = new Sec();
            p1.BackupA();
            p1.BaskupB();
        }
    }
}