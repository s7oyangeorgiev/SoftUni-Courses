double sideOfTriangle = double.Parse(Console.ReadLine());
double heightOfTriangle = double.Parse(Console.ReadLine());

double area = sideOfTriangle * heightOfTriangle / 2;

Console.WriteLine($"{area:f2}");