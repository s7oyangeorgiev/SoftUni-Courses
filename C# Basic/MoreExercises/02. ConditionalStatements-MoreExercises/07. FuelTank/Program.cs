//input
string tipeOfFuel = Console.ReadLine();
double litresInTheTank = double.Parse(Console.ReadLine());

//calculations and output
if (litresInTheTank >= 25 && (tipeOfFuel == "Diesel" || tipeOfFuel == "Gasoline" || tipeOfFuel == "Gas"))
{
    string lCase = tipeOfFuel.ToLower();
    Console.WriteLine($"You have enough {lCase}.");
}
else if (litresInTheTank < 25 && (tipeOfFuel == "Diesel" || tipeOfFuel == "Gasoline" || tipeOfFuel == "Gas"))
{
    string lCase = tipeOfFuel.ToLower();
    Console.WriteLine($"Fill your tank with {lCase}!");
}
else 
{
    Console.WriteLine("Invalid fuel!");
}
