int stayingDays = int.Parse(Console.ReadLine());
string room = Console.ReadLine();
string comment = Console.ReadLine();

double price = 0;

double roomForOnePersonPrice = 18.00;
double apartmentPrice = 25.00;
double presidentApartmentPrice = 35.00;

if (room == "room for one person")
{
    price = (stayingDays - 1) * roomForOnePersonPrice;
}
else if (room == "apartment")
{
    if (stayingDays < 10)
    {
        price = ((stayingDays - 1) * apartmentPrice) * 0.70;
    }
    else if (stayingDays >= 10 && stayingDays <= 15)
    {
        price = ((stayingDays - 1) * apartmentPrice) * 0.65;
    }
    else
    {
        price = ((stayingDays - 1) * apartmentPrice) * 0.50;
    }
}
else if (room == "president apartment")
{
    if (stayingDays < 10)
    {
        price = ((stayingDays - 1) * presidentApartmentPrice) * 0.90;
    }
    else if (stayingDays >= 10 && stayingDays <= 15)
    {
        price = ((stayingDays - 1) * presidentApartmentPrice) * 0.85;
    }
    else
    {
        price = ((stayingDays - 1) * presidentApartmentPrice) * 0.80;
    }
}
if (comment == "positive")
{
    Console.WriteLine($"{price * 1.25:f2}");
}
else
{
    Console.WriteLine($"{price * 0.9:f2}");
}
