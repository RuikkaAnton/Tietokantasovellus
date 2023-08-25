using System.Runtime.CompilerServices;
using Varastonhallinta;

bool correctAnswer = false;

while (!correctAnswer)
{
    Console.WriteLine("VARASTONHALLINTA");
    Console.WriteLine("1 - Lisää tuote");
    Console.WriteLine("2 - Poista tuote");
    Console.WriteLine("3 - Tulosta eri tuotteiden määrät");
    Console.WriteLine("4 - Tulosta kaikki tuotteet");
    Console.WriteLine("5 - Muokkaa tuotenimeä");
    Console.WriteLine("0 - Lopeta sovellus");
    Console.Write("Valintasi on: ");
    string? vastaus = Console.ReadLine();

    switch (vastaus)
    {
        case "1":
            // Lisää tuote
            correctAnswer = true;
            break;

        case "2":
            correctAnswer = true;
            // Poista tuote
            break;

        case "3":
            correctAnswer = true;
            // Tulosta eri tuotteiden määrät
            break;

        case "4":
            correctAnswer = true;
            // Tulosta kaikki tuotteet
            break;

        case "5":
            correctAnswer = true;
            // Muokkaa tuotenimeä
            break;

        case "0":
            correctAnswer = true;
            Environment.Exit(0);
            // Lopeta sovellus
            break;

        default:
            Console.WriteLine("Väärä syöte!");
            break;
    }
    if (correctAnswer)
    {
        break;
    }
}

static void QueringItems()
{

}
