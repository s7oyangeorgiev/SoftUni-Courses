
double partyPrice = double.Parse(Console.ReadLine());
int loveWishesCount = int.Parse(Console.ReadLine());
int rosesCount =  int.Parse(Console.ReadLine());
int keychainCount = int.Parse(Console.ReadLine());
int caricatureCount =  int.Parse(Console.ReadLine());
int surpriseCount = int.Parse(Console.ReadLine());

double loveWishesPrice = 0.60;
double rosePrice = 7.20;
double keychainPrice = 3.60;
double caricaturePrice = 18.20;
double surpricePrice = 22;

double tottalLoveWishesPrice = loveWishesCount * loveWishesPrice;
double tottalRosesPrice = rosesCount * rosePrice;
double tottalKeychainPrice = keychainCount * keychainPrice;
double tottalCAricaturePrice = caricatureCount * caricaturePrice;
double tottalSurpricePrice = surpriseCount * surpricePrice;

double tottalMoneyHave = tottalLoveWishesPrice + tottalRosesPrice + tottalKeychainPrice + tottalCAricaturePrice + tottalSurpricePrice;

int tottalOrderCount = loveWishesCount + rosesCount + keychainCount + caricatureCount + surpriseCount;

if (tottalOrderCount >= 25)
{
    tottalMoneyHave *= 0.65;
}

double tottalMoneyAfterHosting = tottalMoneyHave - (tottalMoneyHave * 0.10);

if (tottalMoneyAfterHosting >= partyPrice)
{
    Console.WriteLine($"Yes! {tottalMoneyAfterHosting - partyPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {partyPrice - tottalMoneyAfterHosting:f2} lv needed.");
}