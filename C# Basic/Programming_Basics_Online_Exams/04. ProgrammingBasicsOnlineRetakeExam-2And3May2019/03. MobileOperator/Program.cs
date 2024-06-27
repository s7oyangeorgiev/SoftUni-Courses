
string contractPeriod = Console.ReadLine();
string tipeOfContract =  Console.ReadLine();
string mobileInternetAdd =  Console.ReadLine();
int mounthForPaying = int.Parse(Console.ReadLine());

double price = 0;
double tottalSum = 0;

if (contractPeriod == "one")
{
    switch (tipeOfContract)
    {
        case "Small": price = 9.98; break;
        case "Middle": price = 18.99; break;
        case "Large": price = 25.98; break;
        case "ExtraLarge": price = 35.99; break;
    }
}
else
{
    switch (tipeOfContract)
    {
        case "Small": price = 8.58; break;
        case "Middle": price = 17.09; break;
        case "Large": price = 23.59; break;
        case "ExtraLarge": price = 31.79; break;
    }
}
if (mobileInternetAdd == "yes")
{
    if (price <= 10.00)
    {
        price += 5.50;
    }
    else if (price <= 30.00)
    {
        price += 4.35;
    }
    else if (price > 30.00)
    {
        price += 3.85;
    }
}
if (contractPeriod == "one")
{
    tottalSum = price * mounthForPaying;
}
else
{
    tottalSum = (price * mounthForPaying) * 0.9625;
}

Console.WriteLine($"{tottalSum:f2} lv.");
