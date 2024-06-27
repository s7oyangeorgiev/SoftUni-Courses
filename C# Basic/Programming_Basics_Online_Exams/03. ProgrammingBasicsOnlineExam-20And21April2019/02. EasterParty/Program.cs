
int guestQuantity = int.Parse(Console.ReadLine());
double priceForOneGuest = double.Parse(Console.ReadLine());
double budget =  double.Parse(Console.ReadLine());

double priceForCake = budget * 0.10;

if (guestQuantity >= 10 && guestQuantity <= 15)
{
    priceForOneGuest *= 0.85;
}
else if (guestQuantity > 15 && guestQuantity <= 20)
{
    priceForOneGuest *= 0.80;
}
else if (guestQuantity > 20)
{
    priceForOneGuest *= 0.75;
}
double tottalPriceForAllGuests = guestQuantity * priceForOneGuest;
double tottalPrice = tottalPriceForAllGuests + priceForCake;

if (budget > tottalPrice)
{
    Console.WriteLine($"It is party time! {budget - tottalPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"No party! {tottalPrice - budget:f2} leva needed.");
}