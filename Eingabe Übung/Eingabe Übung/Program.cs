Console.Write("Gebe deinen Namen ein: ");

string name = Console.ReadLine();

Console.WriteLine("Hallo " + name);
Console.Write("Gebe dein Alter an: ");

int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hallo {0} du bist {1} Jahre alt!", name, age);

// Modulo Operator (Restwert Operator)

int zahl = 6 / 4;

Console.WriteLine(zahl);

int zahl2 = 6 % 4;

Console.WriteLine(zahl2 + "Hallo");
