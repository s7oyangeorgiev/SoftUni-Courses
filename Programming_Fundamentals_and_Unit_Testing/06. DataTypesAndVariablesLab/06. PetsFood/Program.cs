int dogFoodCount = int.Parse(Console.ReadLine());
int catFoodCount = int.Parse(Console.ReadLine());

double dogFoodCosts = dogFoodCount * 2.50;
double catFoodCosts = catFoodCount * 4.00;
double tottalCosts = dogFoodCosts + catFoodCosts;

Console.WriteLine($"{tottalCosts:f2} lv.");
