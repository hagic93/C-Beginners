using System; // source code gdje using kazemo uzmi taj kod i dodjeli ga u file.

namespace LearnCS // tako nam se zove program i onog trenutka kad napravimo program mi pravimo namespace. Namespace je grupisanje koda.
{
    class Program //Program.cs je file a klasa osnovna je program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


// Klase su nacin da pravite sablone a na osnovnu tih sablona ce te napraviti konkretne proizvode odnosno rijesenja za program.
// static void to znaci da u svakom program svakoj klasi osnovnoj kao sto je Program mora da postoji metoda koja ce pokrenuti sve ostale linije Main metoda.
// string[] args to su argumenti stvari koje se salju metodama tj funkcijama za dodatnu obradu.
// Console je klasa koja se nalazi u namespacu system. Klase se organizuju u klasu.
// WriteLine je metoda
// ; mora da se koristi u svakoj liniji koda
