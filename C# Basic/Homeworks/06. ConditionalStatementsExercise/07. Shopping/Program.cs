double petterMoney = double.Parse(Console.ReadLine());
int videoCardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramMemoryCount = int.Parse(Console.ReadLine());

double priceOfVideoCard = videoCardsCount * 250;
double priceOfProcessor = (priceOfVideoCard * 0.35) * processorsCount;
double priceOfRamMemory = (priceOfVideoCard * 0.1) * ramMemoryCount;

double totalAmaount = priceOfVideoCard + priceOfProcessor + priceOfRamMemory;



if (videoCardsCount > processorsCount)
{
    totalAmaount *= 0.85;
}
if (petterMoney >= totalAmaount)
{
    Console.WriteLine($"You have {petterMoney - totalAmaount:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {totalAmaount - petterMoney:f2} leva more!");
}
