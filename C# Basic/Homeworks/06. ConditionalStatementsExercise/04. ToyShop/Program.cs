double tripPrice = double.Parse(Console.ReadLine());
int puzzleCount = int.Parse(Console.ReadLine());
int speakingDollsCount = int.Parse(Console.ReadLine());
int teddyBearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

double sumForToys = (puzzleCount * 2.60) + (speakingDollsCount * 3.00) + (teddyBearsCount * 4.10) + 
    (minionsCount * 8.20) + (trucksCount * 2.00);
int toysCount = puzzleCount + speakingDollsCount + teddyBearsCount + minionsCount + trucksCount;

if (toysCount >= 50)
{
    sumForToys = sumForToys * 0.75;
}
double rentForShop = sumForToys * 0.1;
double profit =  sumForToys - rentForShop;

if (profit >= tripPrice)
{
    Console.WriteLine($"Yes! {profit - tripPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {tripPrice - profit:f2} lv needed.");
}