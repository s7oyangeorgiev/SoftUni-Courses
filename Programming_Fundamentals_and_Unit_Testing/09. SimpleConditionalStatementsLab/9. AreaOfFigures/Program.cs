string typeOfFigure = Console.ReadLine();

if (typeOfFigure == "square")
{
    double sideOfSquare = double.Parse(Console.ReadLine());
    double area = sideOfSquare * sideOfSquare;
    Console.WriteLine($"{area:f2}");
}
else if (typeOfFigure == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());
    double area = width * length;
    Console.WriteLine($"{area:f2}");
}
else if (typeOfFigure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine($"{area:f2}");
}
