using System.ComponentModel.Design;

string season = Console.ReadLine();
string accommodationType =  Console.ReadLine();
int countOfTheDays = int.Parse(Console.ReadLine());

double price = 0;

if ( accommodationType == "Hotel")
{
    switch (season)
    {
        case "Spring": price += (countOfTheDays * 30) * 0.80; break;
        case "Summer": price += (countOfTheDays * 50); break;
        case "Autumn": price += (countOfTheDays * 20) * 0.70; break;
        case "Winter": price += (countOfTheDays * 40) * 0.90; break;
    }
}
else if ( accommodationType == "Camping")
{
    switch (season)
    {
        case "Spring": price += (countOfTheDays * 10) * 0.80; break;
        case "Summer": price += (countOfTheDays * 30); break;
        case "Autumn": price += (countOfTheDays * 15) * 0.70; break;
        case "Winter": price += (countOfTheDays * 10) * 0.90; break;
    }
}

Console.WriteLine($"{price:f2}");