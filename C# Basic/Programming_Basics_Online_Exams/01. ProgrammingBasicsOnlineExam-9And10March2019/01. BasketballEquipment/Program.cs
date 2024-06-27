
double taxPerYear = double.Parse(Console.ReadLine());

double basketballShoestPrice = taxPerYear * 0.6;
double basketballClotesPrice = basketballShoestPrice * 0.8;
double basketballBalllPrice = basketballClotesPrice * 0.25;
double basketballAccesoarysPrice = basketballBalllPrice * 0.2;
double totalPrice = taxPerYear + basketballShoestPrice + basketballClotesPrice + basketballBalllPrice + basketballAccesoarysPrice;

Console.WriteLine($"{totalPrice:f2}");
