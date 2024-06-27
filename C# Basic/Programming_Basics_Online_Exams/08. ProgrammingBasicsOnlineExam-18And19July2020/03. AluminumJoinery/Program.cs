
int joineryQuantity = int.Parse(Console.ReadLine());
string tipeOfjoinery = Console.ReadLine();
string receiving = Console.ReadLine();

double price = 0;

if (joineryQuantity < 10)
{
    Console.WriteLine("Invalid order");
    return;
}
if (tipeOfjoinery == "90X130")
{
    price = 110;
    if (joineryQuantity > 30 && joineryQuantity <= 60)
    {
        price *= 0.95;
    }
    else if (joineryQuantity > 60)
    {
        price *= 0.92;
    }
}
else if (tipeOfjoinery == "100X150")
{
    price = 140;
    if (joineryQuantity > 40 && joineryQuantity <= 80)
    {
        price *= 0.94;
    }
    else if (joineryQuantity > 80)
    {
        price *= 0.90;
    }
}
else if (tipeOfjoinery == "130X180")
{
    price = 190;
    if (joineryQuantity > 20 && joineryQuantity <= 50)
    {
        price *= 0.93;
    }
    else if (joineryQuantity > 50)
    {
        price *= 0.88;
    }
}
else if (tipeOfjoinery == "200X300")
{
    price = 250;
    if (joineryQuantity > 25 && joineryQuantity <= 50)
    {
        price *= 0.91;
    }
    else if (joineryQuantity > 50)
    {
        price *= 0.86;
    }
}
double tottalPrice = joineryQuantity * price;
if (receiving == "With delivery")
{
    tottalPrice += 60;
}
if (joineryQuantity > 99)
{
    tottalPrice *= 0.96;
}
Console.WriteLine($"{tottalPrice:f2} BGN");

