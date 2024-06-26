int chikenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int veggieMenus = int.Parse(Console.ReadLine());

double chikenPrice = 10.35;
double fishPrice = 12.40;
double veggiePrice = 8.15;
double deliveryPrice = 2.50;

double chikenMenuPrice = chikenMenus * chikenPrice;
double fishMenuPrice = fishMenus * fishPrice;
double veggieMenuPrice = veggieMenus * veggiePrice;
double tottalMenusPrice = chikenMenuPrice + fishMenuPrice + veggieMenuPrice;
double desertPrice = tottalMenusPrice * 0.20;

double tottalMoneyNeeded = tottalMenusPrice + desertPrice + deliveryPrice;

Console.WriteLine(tottalMoneyNeeded); 

