
int daysToStay = int.Parse(Console.ReadLine());
string room = Console.ReadLine();
string feetback = Console.ReadLine();

double roomPrice = 0;

switch (room)
{
    case "room for one person": roomPrice = 18.00; break;
    case "apartment": roomPrice = 25.00; break;
    case "president apartment": roomPrice = 35.00; break;
}

double tottalPrice = (daysToStay - 1) * roomPrice;

if (room == "apartment")
{
    if (daysToStay < 10)
    {
        tottalPrice *= 0.70;
    }
    else if (daysToStay >= 10 && daysToStay <= 15)
    {
        tottalPrice *= 0.65;
    }
    else if (daysToStay > 15)
    {
        tottalPrice *= 0.50;
    }
    
}
else if (room == "president apartment")
{
    if (daysToStay < 10)
    {
        tottalPrice *= 0.90;
    }
    else if (daysToStay >= 10 && daysToStay <= 15)
    {
        tottalPrice *= 0.85;
    }
    else if (daysToStay > 15)
    {
        tottalPrice *= 0.80;
    }
}

if (feetback == "positive")
{
    tottalPrice *= 1.25;
}
else
{
    tottalPrice *= 0.90;
}

Console.WriteLine($"{tottalPrice:f2}");
