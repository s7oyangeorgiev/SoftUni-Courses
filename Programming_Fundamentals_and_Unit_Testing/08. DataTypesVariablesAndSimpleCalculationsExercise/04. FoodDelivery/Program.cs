int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegetarianMenus =  int.Parse(Console.ReadLine());

double chickenMenusCosts = chickenMenus * 10.35;
double fishMenusCosts = fishMenus * 12.40;
double vegetarianMenusCosts = vegetarianMenus * 8.15;
double totalMenuCosts = chickenMenusCosts + fishMenusCosts + vegetarianMenusCosts;
double desertCosts = totalMenuCosts * 0.20;
double delivery = 2.50;
double totalCosts = totalMenuCosts + desertCosts + delivery;

Console.WriteLine($"{totalCosts}");
