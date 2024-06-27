string season = Console.ReadLine();
double kmPerMounth = double.Parse(Console.ReadLine());

double pricePerKm = 0;

if (kmPerMounth <= 5_000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            pricePerKm = 0.75;
            break;
        case "Summer":
            pricePerKm = 0.90;
            break;
        case "Winter":
            pricePerKm = 1.05;
            break;
    }
}
else if (kmPerMounth <= 10_000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            pricePerKm = 0.95;
            break;
        case "Summer":
            pricePerKm = 1.10;
            break;
        case "Winter":
            pricePerKm = 1.25;
            break;
    }
}
else
{
    pricePerKm = 1.45;
}
double totalPrice = (kmPerMounth * pricePerKm * 4) * 0.90;
Console.WriteLine($"{totalPrice:f2}");