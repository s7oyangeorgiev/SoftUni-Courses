
double filmBudget = double.Parse(Console.ReadLine());
int extras =  int.Parse(Console.ReadLine());
double priceFOrClotesForOneExtras =  double.Parse(Console.ReadLine());

double decor = filmBudget * 0.10;
double priceForClotes = priceFOrClotesForOneExtras * extras;

if (extras > 150)
{
    priceForClotes *= 0.90;
}

if (decor + priceForClotes > filmBudget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(decor + priceForClotes) - filmBudget:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {filmBudget - (decor + priceForClotes):f2} leva left.");
}