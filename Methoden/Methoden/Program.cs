SayHello("Daniel", 30);
SayHello("Petra", 29);


int zahl = Addition(10, 5);

Console.WriteLine(zahl);
Console.WriteLine(Addition(20,4));



static void SayHello(string name, int age)
{
    Console.WriteLine("Hallo {0}, du bist {1} Jahre alt!", name, age);
}

static int Addition(int number1, int number2)
{
    int ergebnis = number1 + number2;
    return ergebnis;
}

//string firstName = GetTextInput("Gebe deinem Vornamen ein: ");
//string lastName = GetTextInput("Gebe deinem NAchnamen ein: ");

//Console.WriteLine("Hallo {0} {1}");

//static string GetTextInput(string message)
//{
//    Console.Write(message);
//    return Console.ReadLine();
//}

Console.Write("gebe einen radius an : ");
double KreisFläche = GetCircleArea(Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Deine Fläche bträgt {0} quadratmeter", KreisFläche);

static double GetCircleArea(double radius)
{
    double PI = Math.PI;
    double durchmesser = radius * 2;

    double Fläche = (Math.Pow(durchmesser, 2) * PI) / 4;
    return Fläche;
}
