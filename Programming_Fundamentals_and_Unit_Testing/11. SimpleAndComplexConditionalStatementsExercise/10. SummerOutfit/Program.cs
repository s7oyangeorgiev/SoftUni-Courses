int temperature = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

string clothing = "";
string shoes = "";

if ( temperature >= 10 && temperature <= 18)
{
    switch (timeOfDay)
    {
        case "Morning": clothing = "Sweatshirt"; shoes = "Sneakers"; break;
        case "Afternoon": clothing = "Shirt"; shoes = "Moccasins"; break;
        case "Evening": clothing = "Shirt"; shoes = "Moccasins"; break;
    }
}
else if (temperature > 18 && temperature <= 24)
{
    switch (timeOfDay)
    {
        case "Morning": clothing = "Shirt"; shoes = "Moccasins"; break;
        case "Afternoon": clothing = "T-Shirt"; shoes = "Sandals"; break;
        case "Evening": clothing = "Shirt"; shoes = "Moccasins"; break;
    }
}
else if (temperature >= 25)
{
    switch (timeOfDay)
    {
        case "Morning": clothing = "T-Shirt"; shoes = "Sandals"; break;
        case "Afternoon": clothing = "Swim Suit"; shoes = "Barefoot"; break;
        case "Evening": clothing = "Shirt"; shoes = "Moccasins"; break;
    }
}

Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");