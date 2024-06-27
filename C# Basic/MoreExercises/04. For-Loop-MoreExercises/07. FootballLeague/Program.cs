
int stadiumCapacity = int.Parse(Console.ReadLine());
int fansQuantity = int.Parse(Console.ReadLine());

double fansSectorA = 0;
double fansSectorB = 0;
double fansSectorV = 0;
double fansSectorG = 0;


for (int i = 0; i < fansQuantity; i++)
{
    string sector = Console.ReadLine();

    if (sector == "A")
    {
        fansSectorA += 1;
    }
    else if (sector == "B") 
    {
        fansSectorB += 1;
    }
    else if (sector == "V")
    {
        fansSectorV += 1;
    }
    else if (sector == "G")
    {
        fansSectorG += 1;
    }
}
double sumFans = fansSectorA + fansSectorB + fansSectorV + fansSectorG;

Console.WriteLine($"{(fansSectorA / fansQuantity) * 100:f2}%");
Console.WriteLine($"{(fansSectorB / fansQuantity) * 100:f2}%");
Console.WriteLine($"{(fansSectorV / fansQuantity) * 100:f2}%");
Console.WriteLine($"{(fansSectorG / fansQuantity) * 100:f2}%");
Console.WriteLine($"{(sumFans / stadiumCapacity) * 100:f2}%");