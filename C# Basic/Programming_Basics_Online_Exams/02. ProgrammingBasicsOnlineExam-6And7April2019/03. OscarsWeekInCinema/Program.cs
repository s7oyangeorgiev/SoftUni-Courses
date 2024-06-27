
string nameOfTheMovie = Console.ReadLine();
string tipeOfTheRoom = Console.ReadLine();
int ticketQuantity = int.Parse(Console.ReadLine());

double priceForAStarIsBorn = 0;
double priceForBohemianRhapsody = 0;
double priceForGreenBook = 0;
double priceForTheFavourite = 0;

double price = 0;

if (nameOfTheMovie == "A Star Is Born")
{
    switch (tipeOfTheRoom)
    {
        case "normal": price = ticketQuantity * 7.50; break;
        case "luxury": price = ticketQuantity * 10.50; break;
        case "ultra luxury": price = ticketQuantity * 13.50; break;
    }
}
else if (nameOfTheMovie == "Bohemian Rhapsody")
{
    switch (tipeOfTheRoom)
    {
        case "normal": price = ticketQuantity * 7.35; break;
        case "luxury": price = ticketQuantity * 9.45; break;
        case "ultra luxury": price = ticketQuantity * 12.75; break;
    }
}
else if (nameOfTheMovie == "Green Book")
{
    switch (tipeOfTheRoom)
    {
        case "normal": price = ticketQuantity * 8.15; break;
        case "luxury": price = ticketQuantity * 10.25; break;
        case "ultra luxury": price = ticketQuantity * 13.25; break;
    }
}
else
{
    switch (tipeOfTheRoom)
    {
        case "normal": price = ticketQuantity * 8.75; break;
        case "luxury": price = ticketQuantity * 11.55; break;
        case "ultra luxury": price = ticketQuantity * 13.95; break;
    }
}

Console.WriteLine($"{nameOfTheMovie} -> {price:f2} lv.");