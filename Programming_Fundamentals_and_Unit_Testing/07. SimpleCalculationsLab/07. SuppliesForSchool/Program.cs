int numberOfPensPackages = int.Parse(Console.ReadLine());
int numberOfMarkersPackets =  int.Parse(Console.ReadLine());
int litersOfBoarCleaner = int.Parse(Console.ReadLine());
int discountPercentage =  int.Parse(Console.ReadLine());

double pensPrice = numberOfPensPackages * 5.80;
double markersPrice = numberOfMarkersPackets * 7.20;
double boarCleanerPrice = litersOfBoarCleaner * 1.20;

double totalPrice = pensPrice + markersPrice + boarCleanerPrice;
double priceAfterDiscount = totalPrice - (totalPrice * (discountPercentage / 100.00));

Console.WriteLine(priceAfterDiscount);