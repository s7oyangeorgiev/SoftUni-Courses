
double budget = double.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double priceForNight =  double.Parse(Console.ReadLine());
double percentForOtherExpences =  double.Parse(Console.ReadLine());

double priceForAllNights = nights * priceForNight;
double priceForOtherExpences = budget * percentForOtherExpences / 100;


if (nights > 7)
{
    priceForAllNights *= 0.95;
}
double tottalPrice = priceForAllNights + priceForOtherExpences;

if (budget >= tottalPrice)
{
    Console.WriteLine($"Ivanovi will be left with {budget - tottalPrice:f2} leva after vacation.");
}
else
{
    Console.WriteLine($"{tottalPrice - budget:f2} leva needed.");
}