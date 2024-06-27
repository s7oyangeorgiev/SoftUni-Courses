double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int peopleCount = int.Parse(Console.ReadLine());

double ipPrice = 499.99;
double normalPrice = 249.99;

double transportPrice = 0;
double ticketPrice = 0;

if (peopleCount >= 1 && peopleCount <= 4)
{
    transportPrice = budget * 0.75;
}
else if (peopleCount >= 5 && peopleCount <= 9)
{
    transportPrice = budget * 0.60;
}
else if (peopleCount >= 10 && peopleCount <= 24)
{
    transportPrice = budget * 0.50;
}
else if (peopleCount >= 25 && peopleCount <= 49)
{
    transportPrice = budget * 0.40;
}
else if (peopleCount >= 50)
{
    transportPrice = budget * 0.25;
}
if (category == "Normal")
{
    ticketPrice = peopleCount * normalPrice;
}
else
{
    ticketPrice = peopleCount * ipPrice;
}

double finalPrice = transportPrice + ticketPrice;

if (budget >= finalPrice)
{
    double leftMoney = budget - finalPrice;
    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
}
else
{
    double needenMoney = finalPrice - budget;
    Console.WriteLine($"Not enough money! You need {needenMoney:f2} leva.");
}