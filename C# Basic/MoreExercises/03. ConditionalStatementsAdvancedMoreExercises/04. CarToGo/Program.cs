double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string tipeOfCar = "";
double price = 0;
string classCar = "";

if (budget <= 100)
{
    classCar = "Economy class";
    if (season == "Summer")
    {
        tipeOfCar = "Cabrio";
        price = budget * 0.35;
    }
    else
    {
        tipeOfCar = "Jeep";
        price = budget * 0.65;
    }
}
else if (budget <= 500)
{
    classCar = "Compact class";
    if (season == "Summer" )
    {
        tipeOfCar = "Cabrio";
        price = budget * 0.45;
    }
    else
    {
        tipeOfCar = "Jeep";
        price = budget * 0.80;
    }
}
else
{
    classCar = "Luxury class";
    tipeOfCar = "Jeep";
    price = budget * 0.90;
    
}
Console.WriteLine($"{classCar}");
Console.WriteLine($"{tipeOfCar} - {price:f2}");