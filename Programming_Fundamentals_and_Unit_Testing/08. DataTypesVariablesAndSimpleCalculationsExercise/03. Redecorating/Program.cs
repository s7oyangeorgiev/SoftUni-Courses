int nylonNeeded = int.Parse(Console.ReadLine());
int paintNeeded = int.Parse(Console.ReadLine());
int thinnerNeeded = int.Parse(Console.ReadLine());
int hoursNeeded = int.Parse(Console.ReadLine());

double nylonCosts = (nylonNeeded + 2) * 1.50;
double paintCosts = (paintNeeded + (paintNeeded * 0.10)) * 14.50;
double thinnerCosts = thinnerNeeded * 5.00;
double bagCosts = 0.40;
double totalMaterialCosts = nylonCosts + paintCosts + thinnerCosts + bagCosts;
double craftsmen = (totalMaterialCosts * 0.30) * hoursNeeded;
double totalCosts = totalMaterialCosts + craftsmen;

Console.WriteLine($"{totalCosts}");
