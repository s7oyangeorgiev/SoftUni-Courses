double sideB1 = double.Parse(Console.ReadLine());
double sideB2 = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double area = (sideB1 + sideB2) * h / 2;

Console.WriteLine($"{area:f2}");