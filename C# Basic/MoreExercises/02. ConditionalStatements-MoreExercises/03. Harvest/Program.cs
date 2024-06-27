//input
using System;

int xVineyardInSquareMeter = int.Parse(Console.ReadLine());
double yGrapesForOneSquareMeter = double.Parse(Console.ReadLine());
int zLitersWineNeeded = int.Parse(Console.ReadLine());
int workersCount = int.Parse(Console.ReadLine());

//calculations
double totalGrape = xVineyardInSquareMeter * yGrapesForOneSquareMeter;
double totalWine = 0.4 * (totalGrape / 2.5);

//output
if (totalWine < zLitersWineNeeded)
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(zLitersWineNeeded - totalWine)} liters wine needed.");
}
else
{
    double wineLeft = totalWine - zLitersWineNeeded;
    double winePerWorker = wineLeft / workersCount;
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
    Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
}


