
double priceForBagUp20Kg = double.Parse(Console.ReadLine());
double bagKg =  double.Parse(Console.ReadLine());
int daysTillTravel = int.Parse(Console.ReadLine());
int bagsQuantity = int.Parse(Console.ReadLine());

double tax = 0;

if (bagKg < 10)
{
    tax = priceForBagUp20Kg * 0.20;
}
else if (bagKg <= 20)
{
    tax = priceForBagUp20Kg * 0.50;
}
else
{
    tax = priceForBagUp20Kg;
}
if (daysTillTravel > 30)
{
    tax *= 1.10;
}
else if (daysTillTravel >= 7 && daysTillTravel <= 30)
{
    tax *= 1.15;
}
else if (daysTillTravel < 7)
{
    tax *= 1.40;
}
double tottalSum = tax * bagsQuantity;

Console.WriteLine($" The total price of bags is: {tottalSum:f2} lv. ");
