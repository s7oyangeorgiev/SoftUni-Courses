
int EasterBread = int.Parse(Console.ReadLine());
int eggs = int.Parse(Console.ReadLine());
int bisquits = int.Parse(Console.ReadLine());

double priceForEasterBread = EasterBread * 3.20;
double priceForEggs = eggs * 4.35;
double priceForBisquits = bisquits * 5.40;
double priceForPainForEggs = eggs * (12 * 0.15);

double tottalPrice = priceForEasterBread + priceForEggs + priceForBisquits + priceForPainForEggs;

Console.WriteLine($"{tottalPrice:f2}");