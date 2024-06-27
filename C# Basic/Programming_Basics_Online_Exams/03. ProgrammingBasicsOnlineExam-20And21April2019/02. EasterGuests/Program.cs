
double guestQuantity = double.Parse(Console.ReadLine());
double budget =  double.Parse(Console.ReadLine());

double priceForOneEasterBread = 4;
double priceForOneEgg = 0.45;

double EasterBreadNeeded = Math.Ceiling(guestQuantity / 3);
double EggNeeded = guestQuantity * 2;

double priceForAllEasterBreads = EasterBreadNeeded * priceForOneEasterBread;
double priceForAllEggs = EggNeeded * priceForOneEgg;
double tottalPrice = priceForAllEasterBreads + priceForAllEggs;

if (budget >= tottalPrice)
{
    Console.WriteLine($"Lyubo bought {EasterBreadNeeded} Easter bread and {EggNeeded} eggs.");
    Console.WriteLine($"He has {budget - tottalPrice:f2} lv. left.");
}
else
{
    Console.WriteLine("Lyubo doesn't have enough money.");
    Console.WriteLine($"He needs {tottalPrice - budget:f2} lv. more.");
}