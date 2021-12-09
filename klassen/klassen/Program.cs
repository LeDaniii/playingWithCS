using klassen;

Bankkonto konto = new Bankkonto();
Bankkonto konto2 = new Bankkonto();

konto.Kontostand = 2500;
konto.Besitzer = "Sandra Müller";

konto.Einzahlen(250);

konto.Auszahlen(300);

Console.WriteLine("Kontostand: " + konto.Kontostand);

Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

konto2.Kontostand = 6500;
konto2.Besitzer = "Daniel Matzer";

konto2.Einzahlen(500);

Console.ReadKey();