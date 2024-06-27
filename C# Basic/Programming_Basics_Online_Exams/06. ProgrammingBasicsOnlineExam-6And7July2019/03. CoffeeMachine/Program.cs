
string drinks = Console.ReadLine();
string shugar = Console.ReadLine();
int drinksQuantity = int.Parse(Console.ReadLine());

double price = 0;

if (drinks == "Espresso")
{
    switch (shugar)
    {
        case "Without": price = 0.90; break;
        case "Normal": price = 1.00; break;
        case "Extra": price = 1.20; break;
    }
}
else if (drinks == "Cappuccino")
{
    switch (shugar)
    {
        case "Without": price = 1.00; break;
        case "Normal": price = 1.20; break;
        case "Extra": price = 1.60; break;
    }
}
else
{
    switch (shugar)
    {
        case "Without": price = 0.50; break;
        case "Normal": price = 0.60; break;
        case "Extra": price = 0.70; break;
    }
}
if (shugar == "Without")
{
    price *= 0.65;
}
if (drinks == "Espresso" && drinksQuantity > 5)
{
    price *= 0.75;
}
double tottalPrice = price * drinksQuantity;
if (tottalPrice > 15)
{
    tottalPrice *= 0.80;
}

Console.WriteLine($"You bought {drinksQuantity} cups of {drinks} for {tottalPrice:f2} lv.");

