string figure = Console.ReadLine();

if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    double areaSquare = side * side;
    Console.WriteLine($"{areaSquare:f3}");
}
else if (figure == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    double areaRectangle = sideA * sideB;
    Console.WriteLine($"{areaRectangle:f3}");
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double areaCircle = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine($"{areaCircle:f3}");
}
else if (figure == "triangle")
{
    double lenghtSideA = double.Parse(Console.ReadLine());
    double hightSideA = double.Parse(Console.ReadLine());
    double areaTriangle = lenghtSideA * hightSideA / 2;
    Console.WriteLine($"{areaTriangle:f3}");
}

