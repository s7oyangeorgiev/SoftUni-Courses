int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fisherman = int.Parse(Console.ReadLine());

int shipPrice = 0;
double discount = 0;

if (season == "Spring")
{
    shipPrice = 3_000;
}
else if (season == "Summer")
{
    shipPrice = 4_200;
}
else if (season == "Autumn")
{
    shipPrice = 4_200;
}
else if (season == "Winter")
{
    shipPrice = 2_600;
}
if (fisherman <= 6)
{
    discount = 0.10;
}
else if(fisherman <= 11)
{
    discount = 0.15;
}
else if (fisherman >= 12)
{
    discount = 0.25;
}
double finalPrice = shipPrice - (shipPrice * discount);

if (fisherman % 2 == 0 && season != "Autumn")
{
    finalPrice = finalPrice - (finalPrice * 0.05);
}

if (budget >= finalPrice)
{
    
    Console.WriteLine($"Yes! You have {budget - finalPrice:f2} leva left.");
}
else
{
      Console.WriteLine($"Not enough money! You need {finalPrice - budget:f2} leva.");
}