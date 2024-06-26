double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0;
string destination = "";
string kindOfVacantion = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        price = budget * 0.30;
    }
    else if (season == "winter")
    {
        price = budget * 0.70;
    }
}
else if (budget <= 1_000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        price = budget * 0.40;
    }
    else if (season == "winter")
    {
        price = budget * 0.80;
    }
}
else if (budget > 1_000)
{
    destination = "Europe";
    price = budget * 0.90;

}
if (destination == "Bulgaria" && season == "summer")
{
    kindOfVacantion = "Camp";
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{kindOfVacantion} - {price:f2}");
}
else if (destination == "Bulgaria" && season == "winter")
{
    kindOfVacantion = "Hotel";
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{kindOfVacantion} - {price:f2}");
}
else if (destination == "Balkans" && season == "summer")
{
    kindOfVacantion = "Camp";
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{kindOfVacantion} - {price:f2}");
}
else if (destination == "Balkans" && season == "winter")
{
    kindOfVacantion = "Hotel";
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{kindOfVacantion} - {price:f2}");
}
else
{
    kindOfVacantion = "Hotel";
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{kindOfVacantion} - {price:f2}");
}