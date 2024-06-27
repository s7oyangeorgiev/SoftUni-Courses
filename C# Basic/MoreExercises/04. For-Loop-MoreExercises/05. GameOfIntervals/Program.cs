
double movesInGame = double.Parse(Console.ReadLine());

double points = 0;
double numTo9 = 0;
double numTo19 = 0;
double numTo29 = 0;
double numTo39 = 0;
double numTo50 = 0;
double numUp50 = 0;


for (int i = 0; i < movesInGame; i++)
{
    double numberForMove = double.Parse(Console.ReadLine());

    if (numberForMove >= 0 && numberForMove <= 9)
    {
        points += numberForMove * 0.20;
        numTo9 += 1;
    }
    else if (numberForMove >= 10 && numberForMove <= 19)
    {
        points += numberForMove * 0.30;
        numTo19 += 1;
    }
    else if (numberForMove >= 20 && numberForMove <= 29)
    {
        points += numberForMove * 0.40;
        numTo29 += 1;
    }
    else if (numberForMove >= 30 && numberForMove <= 39)
    {
        points += 50;
        numTo39 += 1;
    }
    else if (numberForMove >= 40 && numberForMove <= 50)
    {
        points += 100;
        numTo50 += 1;
    }
    if (numberForMove < 0 ||  numberForMove > 50)
    {
        points = points / 2;
        numUp50 += 1;
    }
}
Console.WriteLine($"{points:f2}");
Console.WriteLine($"From 0 to 9: {numTo9 / movesInGame * 100:f2}%");
Console.WriteLine($"From 10 to 19: {numTo19 / movesInGame * 100:f2}%");
Console.WriteLine($"From 20 to 29: {numTo29 / movesInGame * 100:f2}%");
Console.WriteLine($"From 30 to 39: {numTo39 / movesInGame * 100:f2}%");
Console.WriteLine($"From 40 to 50: {numTo50 / movesInGame * 100:f2}%");
Console.WriteLine($"Invalid numbers: {numUp50 / movesInGame * 100:f2}%");