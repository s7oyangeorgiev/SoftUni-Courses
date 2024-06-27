
double strawberriestPrice = double.Parse(Console.ReadLine());
double bananaQuantity = double.Parse(Console.ReadLine());
double orangeQuantity = double.Parse(Console.ReadLine());
double raspberriesQuantity = double.Parse(Console.ReadLine());
double strawberriesQuantity =  double.Parse(Console.ReadLine());

double raspberriesPrice = strawberriestPrice * 0.5;
double orangePrice = raspberriesPrice * 0.6;
double bananaPrice = raspberriesPrice * 0.2;

double tottalStrawberriesPrice = strawberriesQuantity * strawberriestPrice;
double tottalBananasPrice = bananaQuantity * bananaPrice;
double tottalOrangesPrice = orangeQuantity * orangePrice;
double tottalRaspberriesPrice = raspberriesQuantity * raspberriesPrice;

double tottalPrice = tottalStrawberriesPrice + tottalBananasPrice + tottalOrangesPrice + tottalRaspberriesPrice;

Console.WriteLine($"{tottalPrice:f2}");

