
string townName = Console.ReadLine();
string tipeOfPack = Console.ReadLine();
string vipDiscount = Console.ReadLine();
int daysToStay = int.Parse(Console.ReadLine());

double price = 0;

if (townName == "Bansko" || townName == "Borovets")
{
    if (tipeOfPack == "withEquipment")
    {
        price = 100;
        if (vipDiscount == "yes")
        {
            price *= 0.9;
        }
    }
    else if (tipeOfPack == "noEquipment")
    {
        price = 80;
        if (vipDiscount == "yes")
        {
            price *= 0.95;
        }
    }  
}
if (townName == "Varna" || townName == "Burgas")
{
    if (tipeOfPack == "withBreakfast")
    {
        price = 130;
        if (vipDiscount == "yes")
        {
            price *= 0.88;
        }
    }
    else if (tipeOfPack == "noBreakfast")
    {
        price = 100;
        if (vipDiscount == "yes")
        {
            price *= 0.93;
        }
    }
}
if (daysToStay > 7)
{
    daysToStay -= 1;
}
double tottalSum = daysToStay * price;

if (tipeOfPack != "noEquipment" && tipeOfPack != "withEquipment" && tipeOfPack != "noBreakfast" && tipeOfPack != "withBreakfast")
{
    Console.WriteLine("Invalid input!");
}
else if (townName != "Bansko" && townName != "Borovets" && townName != "Varna" && townName != "Burgas")
{
    Console.WriteLine("Invalid input!");
}
else if (daysToStay < 1)
{
    Console.WriteLine("Days must be positive number!");
}
else
{
    Console.WriteLine($"The price is {tottalSum:f2}lv! Have a nice time!");
}