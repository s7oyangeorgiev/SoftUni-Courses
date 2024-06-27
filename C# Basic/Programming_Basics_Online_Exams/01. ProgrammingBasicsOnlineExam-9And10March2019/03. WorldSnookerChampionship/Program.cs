
string championshipStage = Console.ReadLine();
string ticketTipe = Console.ReadLine();
int ticketQuantity = int.Parse(Console.ReadLine());
char pictureWithTrophey = char.Parse(Console.ReadLine());

double TicketPrice = 0;


if (championshipStage == "Quarter final")
{
    switch (ticketTipe)
    {
        case "Standard": TicketPrice = 55.50; break;
        case "Premium": TicketPrice = 105.20; break;
        case "VIP": TicketPrice = 118.90; break;

    }
}
else if (championshipStage == "Semi final")
{
    switch (ticketTipe)
    {
        case "Standard": TicketPrice = 75.88; break;
        case "Premium": TicketPrice = 125.22; break;
        case "VIP": TicketPrice = 300.40; break;

    }
}
else if (championshipStage == "Final")
{
    switch (ticketTipe)
    {
        case "Standard": TicketPrice = 110.10; break;
        case "Premium": TicketPrice = 160.66; break;
        case "VIP": TicketPrice = 400; break;

    }
}
double totalPrice = ticketQuantity * TicketPrice;

if (totalPrice > 4_000)
{
    totalPrice *= 0.75;
}
else if (totalPrice > 2_500 && totalPrice <= 4_000)
{
    totalPrice *= 0.90;

    if (pictureWithTrophey == 'Y')
    {
        totalPrice += ticketQuantity * 40;
    }
}
else if (pictureWithTrophey == 'Y')
{
    totalPrice += ticketQuantity * 40;
}

Console.WriteLine($"{totalPrice:f2}");


