
string fruit = Console.ReadLine();
string set =  Console.ReadLine();
int setQuantity = int.Parse(Console.ReadLine());

double price = 0;

if (fruit == "Watermelon")
{
    switch (set)
    {
        case "small": price = 2 * 56; break;
        case "big": price = 5 * 28.70; break;
    }
}
else if (fruit == "Mango")
{
    switch (set)
    {
        case "small": price = 2 * 36.66; break;
        case "big": price = 5 * 19.60; break;
    }
}
else if (fruit == "Pineapple")
{
    switch (set)
    {
        case "small": price = 2 * 42.10; break;
        case "big": price = 5 * 24.80; break;
    }
}
else
{
    switch (set)
    {
        case "small": price = 2 * 20; break;
        case "big": price = 5 * 15.20; break;
    }
}
double tottalPrice = setQuantity * price;

if (tottalPrice >= 400 && tottalPrice <= 1_000)
{
    tottalPrice *= 0.85;
}
else if (tottalPrice > 1_000)
{
    tottalPrice *= 0.5;
}

Console.WriteLine($"{tottalPrice:f2} lv.");