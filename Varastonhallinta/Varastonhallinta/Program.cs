using Microsoft.EntityFrameworkCore.Update;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
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
            Console.Write("Tuotteen Id: ");
            int vastausId = ReadNumber();
            Console.Write("Tuotteen nimi: ");
            string vastausTuotenimi= ReadString();
            Console.Write("Tuotteen hinta:");
            int vastausHinta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tuotteen varastosaldo: ");
            int varastoVastaus = Convert.ToInt32(Console.ReadLine());
            AddItems(vastausId, vastausTuotenimi, vastausHinta, varastoVastaus);
            correctAnswer = false;
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
}

int ReadNumber()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Väärä syöte. Kokeile uudestaan!");
    }
    return number;
}

 string ReadString()
{
    string s;
    while (true)
    {
        s = Console.ReadLine();

        if (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Väärä syöte. Kokeile uudestaan!");
            continue;
        }
        break;
    }
    return s;
}

static void QueringItems()
{
    using Varastonhallinta.Varastonhallinta varastonhallinta = new();
    IQueryable<Tuote>? allItems = varastonhallinta.Tuotteet;

    if (allItems is null)
    {
        Console.WriteLine("Yhtään tuotetta ei ole vielä lisätty");
        return;
    }
}

static bool AddItems(int uusiId, string uusiTuotenimi, int uusiTuotteenhinta, int uusiVarastosaldo)
{
    using Varastonhallinta.Varastonhallinta varastonhallinta = new();
    Tuote tuote = new()
    {
        Id = uusiId,
        Tuotenimi = uusiTuotenimi,
        Tuotteenhinta= uusiTuotteenhinta,
        Varastosaldo = uusiVarastosaldo
    };

    varastonhallinta.Tuotteet?.Add(tuote);
    int affected = varastonhallinta.SaveChanges();
    return affected == 1;
}

static int DeleteItems(int id)
{
    using Varastonhallinta.Varastonhallinta varastonhallinta = new();

    Tuote tuoteDelete = varastonhallinta.Tuotteet.Find(id);
    if(tuoteDelete is null)
    {
        return 0;
    }
    else
    {
        varastonhallinta.Remove(tuoteDelete);
        int affected = varastonhallinta.SaveChanges();
        return affected;
    }
}

static bool ChangeName(string uusiNimi, int id)
{
    using Varastonhallinta.Varastonhallinta varastonhallinta = new();

    Tuote tuoteUpdate = varastonhallinta.Tuotteet.FirstOrDefault(tuote => tuote.Id== id);
    
    if (tuoteUpdate is null)
    {
        return false;
    }
    else
    {
        tuoteUpdate.Tuotenimi = uusiNimi;
        int affected = varastonhallinta.SaveChanges();
        return affected == 1;
    }
}
