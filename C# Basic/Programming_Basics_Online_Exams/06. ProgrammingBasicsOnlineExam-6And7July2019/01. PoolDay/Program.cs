
int peopeQuantity = int.Parse(Console.ReadLine());
double taxForEntry = double.Parse(Console.ReadLine());
double priceForOneSunLounger =  double.Parse(Console.ReadLine());
double priceForOneUmbrella =  double.Parse(Console.ReadLine());

double taxForAllPeople = peopeQuantity * taxForEntry;
double sunLoungerNeeded = Math.Ceiling(peopeQuantity * 0.75);
double priceForSunLounger = sunLoungerNeeded * priceForOneSunLounger;
double umbrellaNeeded = Math.Ceiling(peopeQuantity * 0.50);
double priceForUmbrella = umbrellaNeeded * priceForOneUmbrella;

double tottalSum = taxForAllPeople + priceForSunLounger + priceForUmbrella;

Console.WriteLine($"{tottalSum:f2} lv.");