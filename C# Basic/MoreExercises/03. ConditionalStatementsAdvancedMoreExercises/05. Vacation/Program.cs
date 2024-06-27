double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string accommodation = "";
string location = "";
double price = 0;

if (budget <= 1_000)
{
    accommodation = "Camp";
    switch (season)
    {
        case "Summer": location = "Alaska"; price = budget * 0.65; break;
        case "Winter": location = "Morocco"; price = budget * 0.45; break;
    }
}
else if (budget <= 3_000)
{
    accommodation = "Hut";
    switch (season)
    {
        case "Summer": location = "Alaska"; price = budget * 0.80; break;
        case "Winter": location = "Morocco"; price = budget * 0.60; break;
    }
}
else
{
    accommodation = "Hotel";
    switch (season)
    {
        case "Summer": location = "Alaska"; price = budget * 0.90; break;
        case "Winter": location = "Morocco"; price = budget * 0.90; break;
    }
}
Console.WriteLine($"{location} - {accommodation} - {price:f2}");