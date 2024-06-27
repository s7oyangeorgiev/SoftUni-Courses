
string destination = Console.ReadLine();
string period = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double price = 0;

if (destination == "France")
{
    switch (period)
    {
        case "21-23": price = 30; break;
        case "24-27": price = 35; break;
        case "28-31": price = 40; break;
    }
}
else if (destination == "Italy")
{
    switch (period)
    {
        case "21-23": price = 28; break;
        case "24-27": price = 32; break;
        case "28-31": price = 39; break;
    }
}
else
{
    switch (period)
    {
        case "21-23": price = 32; break;
        case "24-27": price = 37; break;
        case "28-31": price = 43; break;
    }
}

double tottalPrice = price * nights;

Console.WriteLine($"Easter trip to {destination} : {tottalPrice:f2} leva.");