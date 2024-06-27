
string eggsSize = Console.ReadLine();
string eggsColor = Console.ReadLine();
int numberOfLots = int.Parse(Console.ReadLine());

double price = 0;

if (eggsSize == "Large")
{
    switch (eggsColor)
    {
        case "Red": price = 16; break;
        case "Green": price = 12; break;
        case "Yellow": price = 9; break;
    }
}
if (eggsSize == "Medium")
{
    switch (eggsColor)
    {
        case "Red": price = 13; break;
        case "Green": price = 9; break;
        case "Yellow": price = 7; break;
    }
}
else if (eggsSize == "Small")
{
    switch (eggsColor)
    {
        case "Red": price = 9; break;
        case "Green": price = 8; break;
        case "Yellow": price = 5; break;
    }
}

Console.WriteLine($"{(price * numberOfLots) * 0.65:f2} leva.");