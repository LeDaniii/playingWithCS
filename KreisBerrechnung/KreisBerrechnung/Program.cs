Console.Write("gebe einen radius an : ");
double KreisFläche = GetCircleArea(Convert.ToDouble(Console.ReadLine()));

Console.WriteLine("Deine Fläche bträgt {0} quadratmeter", KreisFläche);

static double GetCircleArea(double radius)
{
    double PI = Math.PI;
    double durchmesser = radius * 2;

    double Fläche = (Math.Pow(durchmesser, 2) * PI) / 4;
    return Fläche;
}
