int numberOfChrysanthemums = int.Parse(Console.ReadLine());
int numberOfRoses = int.Parse(Console.ReadLine());
int numberOfTulips =  int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char holiday = char.Parse(Console.ReadLine());

double chrysanthemumsPrice = 0;
double rosesPrice = 0;
double tulipPrice = 0;
double totalPrice = 0;

if (season == "Spring" || season == "Summer")
{
    if (holiday == 'Y')
    {
        chrysanthemumsPrice = 2.00 * 1.15;
        rosesPrice = 4.10 * 1.15;
        tulipPrice = 2.50 * 1.15;
        totalPrice = (numberOfChrysanthemums * chrysanthemumsPrice) + (numberOfRoses * rosesPrice) +
    (numberOfTulips * tulipPrice);
    }
    else
    {
        chrysanthemumsPrice = 2.00;
        rosesPrice = 4.10;
        tulipPrice = 2.50;
        totalPrice = (numberOfChrysanthemums * chrysanthemumsPrice) + (numberOfRoses * rosesPrice) +
    (numberOfTulips * tulipPrice);
    }
}
else
{
    if (holiday == 'Y')
    {
        chrysanthemumsPrice = 3.75 * 1.15;
        rosesPrice = 4.50 * 1.15;
        tulipPrice = 4.15 * 1.15;
        totalPrice = (numberOfChrysanthemums * chrysanthemumsPrice) + (numberOfRoses * rosesPrice) +
    (numberOfTulips * tulipPrice);
    }
    else
    {
        chrysanthemumsPrice = 3.75;
        rosesPrice = 4.50;
        tulipPrice = 4.15;
        totalPrice = (numberOfChrysanthemums * chrysanthemumsPrice) + (numberOfRoses * rosesPrice) +
    (numberOfTulips * tulipPrice);
    }
}
if (numberOfTulips > 7 && season == "Spring")
{
    totalPrice *= 0.95;
    
}
if (numberOfRoses >= 10 && season == "Winter")
{
    totalPrice *= 0.90;
   
}
if (numberOfChrysanthemums + numberOfRoses + numberOfTulips > 20)
{
    totalPrice *= 0.80;
}
else
{
    Console.WriteLine($"{totalPrice + 2:f2}");
    return;

}
Console.WriteLine($"{totalPrice + 2:f2}");