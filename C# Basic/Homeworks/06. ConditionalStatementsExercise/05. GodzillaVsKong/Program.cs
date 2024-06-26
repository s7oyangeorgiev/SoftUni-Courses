double moneyForMovie = double.Parse(Console.ReadLine());
int numberOfExtras = int.Parse(Console.ReadLine());
double priceForClotesForOneExtras = double.Parse(Console.ReadLine());

double sumForDecoor = moneyForMovie * 0.1;
double sumForClotes = numberOfExtras * priceForClotesForOneExtras;
double allMoneyForMovie = moneyForMovie - (sumForDecoor + sumForClotes);

if (numberOfExtras > 150)
{
    sumForClotes = sumForClotes * 0.9;
    allMoneyForMovie = moneyForMovie - sumForClotes;
}
if  (sumForDecoor + sumForClotes > moneyForMovie)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(sumForDecoor + sumForClotes) - moneyForMovie:f2} leva more.");
}
else
{
    allMoneyForMovie = moneyForMovie - (sumForDecoor + sumForClotes);
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {allMoneyForMovie:f2} leva left.");
}