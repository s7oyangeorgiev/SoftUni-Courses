
double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int daysQuanity = int.Parse(Console.ReadLine());

double price = 0;

if (destination == "Dubai")
{
    switch (season)
    {
        case "Winter": price = 45_000; break;
        case "Summer": price = 40_000; break;
    }
    price *= 0.70;
}
else if (destination == "Sofia")
{
    switch (season)
    {
        case "Winter": price = 17_000; break;
        case "Summer": price = 12_500; break;
    }
    price *= 1.25;
}
else
{
    switch (season)
    {
        case "Winter": price = 24_000; break;
        case "Summer": price = 20_250; break;
    }
}
double tottalSum = daysQuanity * price;

if (budget > tottalSum)
{
    Console.WriteLine($"The budget for the movie is enough! We have {budget - tottalSum:f2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {tottalSum - budget:f2} leva more!");
}