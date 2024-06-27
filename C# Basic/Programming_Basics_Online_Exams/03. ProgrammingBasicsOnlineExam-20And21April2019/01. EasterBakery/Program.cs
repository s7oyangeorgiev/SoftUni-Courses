
double priceForKgFlour = double.Parse(Console.ReadLine());
double flourKg = double.Parse(Console.ReadLine());
double sugarKg = double.Parse(Console.ReadLine());
int eggsX12 = int.Parse(Console.ReadLine());
int packsOfYeast =  int.Parse(Console.ReadLine());

double priceForKgSugar = priceForKgFlour * 0.75;
double priceForEggsX12 = priceForKgFlour * 1.10;
double priceForYeast = priceForKgSugar * 0.20;

double tottalPriceForSugar = priceForKgSugar * sugarKg;
double tottalPriceFOrEggs = eggsX12 * priceForEggsX12;
double tottalPriceForYeast = packsOfYeast * priceForYeast;
double tottalPriceForFlour = flourKg * priceForKgFlour;

double tottalPrice = tottalPriceForSugar + tottalPriceFOrEggs + tottalPriceForYeast + tottalPriceForFlour;

Console.WriteLine($"{tottalPrice:f2}");
