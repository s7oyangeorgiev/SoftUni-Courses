
int age = int.Parse(Console.ReadLine());
double washingMashinePrice = double.Parse(Console.ReadLine());
int priceForOneToy = int.Parse(Console.ReadLine());

double sum = 0;
int moneyToBeRecieved = 10;

for (int currAge = 1; currAge <= age; currAge++)
{
    if (currAge % 2 == 0)
    {
        sum += moneyToBeRecieved - 1;
        moneyToBeRecieved += 10;
    }
    else
    {
        sum += priceForOneToy;
    }
}
if (sum >= washingMashinePrice)
{
    Console.WriteLine($"Yes! {sum - washingMashinePrice:f2}");
}
else
{
    Console.WriteLine($"No! {washingMashinePrice - sum:f2}");
}
