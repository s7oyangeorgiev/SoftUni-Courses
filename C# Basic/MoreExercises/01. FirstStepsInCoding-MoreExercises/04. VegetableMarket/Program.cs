double priceForOneKgVegetables = double.Parse(Console.ReadLine());
double priceForOneKgFruits =  double.Parse(Console.ReadLine());
int totalKgOfVegetables = int.Parse(Console.ReadLine());
int totalKgOfFruits =  int.Parse(Console.ReadLine());

double priceOfVegetables = totalKgOfVegetables * priceForOneKgVegetables;
double priceOfFruits = totalKgOfFruits * priceForOneKgFruits;

double total = (priceOfVegetables + priceOfFruits) / 1.94;

Console.WriteLine($"{total:f2}");