int juniorBicycleRiders = int.Parse(Console.ReadLine());
int seniorBicycleRiders = int.Parse(Console.ReadLine());
string trace =  Console.ReadLine();

double tax = 0;

if (trace == "trail")
{
    tax = (juniorBicycleRiders * 5.50) + (seniorBicycleRiders * 7);
}
else if (trace == "cross-country")
{
    if ((juniorBicycleRiders + seniorBicycleRiders) >= 50)
    {
        tax = ((juniorBicycleRiders * 8.00) + (seniorBicycleRiders * 9.50)) * 0.75;
    }
    else
    {
        tax = (juniorBicycleRiders * 8.00) + (seniorBicycleRiders * 9.50);
    }
}
else if (trace == "downhill")
{
    tax = (juniorBicycleRiders * 12.25) + (seniorBicycleRiders * 13.75);
}
else if (trace == "road")
{
    tax = (juniorBicycleRiders * 20.00) + (seniorBicycleRiders * 21.50);
}

double expences = tax * 0.95;

Console.WriteLine($"{expences:f2}");