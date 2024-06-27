
double budget = double.Parse(Console.ReadLine());
double petrolNeeded = double.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

double petrolPrice = petrolNeeded * 2.10;
double tourGuidePrice = 100;
double tottalPrice = petrolPrice + tourGuidePrice;

switch (dayOfTheWeek)
{
    case "Saturday": tottalPrice *= 0.90; break;
    case "Sunday": tottalPrice *= 0.80; break;
}

if (budget >= tottalPrice)
{
    Console.WriteLine($"Safari time! Money left: {budget - tottalPrice:f2} lv. ");
}
else
{
    Console.WriteLine($"Not enough money! Money needed: {tottalPrice - budget:f2} lv.");
}