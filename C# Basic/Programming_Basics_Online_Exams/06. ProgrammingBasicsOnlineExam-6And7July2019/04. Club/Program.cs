
double profitTarget = double.Parse(Console.ReadLine());
string nameOfCocktail = Console.ReadLine();

double tottalPrice = 0;
bool isTarget = false;

while (nameOfCocktail != "Party!")
{
    double priceOfCocktail = nameOfCocktail.Length;
    int cocktailsCount = int.Parse(Console.ReadLine());
    double priceOfAllCocktails = cocktailsCount * priceOfCocktail;

    if (priceOfAllCocktails % 2 == 1)
    {
        priceOfAllCocktails *= 0.75;
    }
    tottalPrice += priceOfAllCocktails;

    if (profitTarget <= tottalPrice)
    {
        isTarget = true;
        break;
    }

        nameOfCocktail = Console.ReadLine();
}
if (isTarget)
{
    Console.WriteLine("Target acquired.");
    Console.WriteLine($"Club income - {tottalPrice:f2} leva.");
}
else
{
    Console.WriteLine($"We need {profitTarget - tottalPrice:f2} leva more.");
    Console.WriteLine($"Club income - {tottalPrice:f2} leva.");
}