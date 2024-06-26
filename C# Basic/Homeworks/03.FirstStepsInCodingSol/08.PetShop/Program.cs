int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());
double dogFoodTottal = dogFood * 2.50;
double catFoodTottal = catFood * 4;
double tottalAmount = catFoodTottal + dogFoodTottal;

Console.WriteLine($"{tottalAmount} lv.");

