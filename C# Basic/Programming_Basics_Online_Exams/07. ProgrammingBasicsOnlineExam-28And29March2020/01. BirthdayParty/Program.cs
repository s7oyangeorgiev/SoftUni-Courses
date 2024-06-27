
double priceOfHall = double.Parse(Console.ReadLine());

double priceForCake = priceOfHall * 0.20;
double priceForDrinks = priceForCake * 0.55;
double priceOfAnime = priceOfHall / 3;

double tottalSum = priceOfHall + priceForCake + priceForDrinks + priceOfAnime;

Console.WriteLine($"{tottalSum}");

