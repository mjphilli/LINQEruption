List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

Eruption? eruption1 = eruptions.FirstOrDefault(l => l.Location == "Chile");
Console.WriteLine(eruption1);

Eruption? eruption2 = eruptions.FirstOrDefault(l => l.Location == "Hawaiian Is");
Console.WriteLine((eruption2 != null) ? eruption2 : "No Hawaiian Is Eruption found.");

Eruption? eruption3 = eruptions.FirstOrDefault(l => l.Location == "Greenland");
Console.WriteLine((eruption3 != null) ? eruption3 : "No Greenland Eruption found.");

Eruption? eruption4 = eruptions.Where(y => y.Year > 1900).FirstOrDefault(l => l.Location == "New Zealand");
Console.WriteLine(eruption4);

IEnumerable<Eruption> eruptions5 = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(eruptions5, "eruptions 5");

IEnumerable<Eruption> eruptions6 = eruptions.Where(v => v.Volcano.StartsWith("L"));
PrintEach(eruptions6, "eruptions 6");
Console.WriteLine(eruptions6.Count());

int eruption7 = eruptions.Max(eruption1 => eruption1.ElevationInMeters);
Console.WriteLine(eruption7);

string eruption8 = eruptions.Where(e => e.ElevationInMeters == eruption7).Select(v => v.Volcano).First();
Console.WriteLine(eruption8);

IEnumerable<string> eruptions9 = eruptions.OrderBy(v => v.Volcano).Select(v => v.Volcano);
PrintEachStr(eruptions9, "eruptions 9");

int eruption10 = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine(eruption10);

bool eruption11 = eruptions.Any(y => y.Year == 2000);
Console.WriteLine(eruption11);

IEnumerable<Eruption> eruption12 = eruptions.Where(t => t.Type == "Stratovolcano").Take(3);
PrintEach(eruption12, "eruptions 12");

IEnumerable<Eruption> eruption13 = eruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano);
PrintEach(eruption13, "eruptions 13");

IEnumerable<string> eruption14 = eruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano).Select(v => v.Volcano);
PrintEachStr(eruption14, "eruptions 14");

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

static void PrintEachStr(IEnumerable<string> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (string item in items)
    {
        Console.WriteLine(item.ToString());
    }
}