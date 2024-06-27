
string project = Console.ReadLine();
string packageForMovie = Console.ReadLine();
int ticketQuantity = int.Parse(Console.ReadLine());

double price = 0;

if (project == "John Wick")
{
    switch (packageForMovie)
    {
        case "Drink": price = 12; break;
        case "Popcorn": price = 15; break;
        case "Menu": price = 19; break;
    }
}
else if (project == "Star Wars")
{
    switch (packageForMovie)
    {
        case "Drink": price = 18; break;
        case "Popcorn": price = 25; break;
        case "Menu": price = 30; break;
    }
    if (ticketQuantity >= 4)
    {
        price *= 0.70;
    }
}
else
{
    switch (packageForMovie)
    {
        case "Drink": price = 9; break;
        case "Popcorn": price = 11; break;
        case "Menu": price = 14; break;
    }
    if (ticketQuantity == 2)
    {
        price *= 0.85;
    }
}
double tottalSum = ticketQuantity * price;

Console.WriteLine($"Your bill is {tottalSum:f2} leva.");