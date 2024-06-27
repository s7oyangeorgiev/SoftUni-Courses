
double tennisRacketPrice = double.Parse(Console.ReadLine());
int tenisRacketQuantity  = int.Parse(Console.ReadLine());
int pairShoesQuantity = int.Parse(Console.ReadLine());



double rachetPrice = tenisRacketQuantity * tennisRacketPrice;
double onePairShoesPrice = tennisRacketPrice / 6;
double priceForAllShoes = pairShoesQuantity * onePairShoesPrice;
double priceOfOtherEqupment = (rachetPrice + priceForAllShoes) * 0.2;
double totalPrice = rachetPrice + priceForAllShoes + priceOfOtherEqupment;
double hisPrice = totalPrice / 8;
double sponsorsPrice = totalPrice * 7 / 8;

Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(hisPrice)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorsPrice)}");
