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
        break;

    case "2":
        // Poista tuote
        break;

    case "3":
        // Tulosta eri tuotteiden määrät
        break;

    case "4":
        // Tulosta kaikki tuotteet
        break;

    case "5":
        // Muokkaa tuotenimeä
        break;

    case "0":
        // Lopeta sovellus
        break;

    default:
        Console.WriteLine("Kirjoita uudestaan.");
            break;

            
}
