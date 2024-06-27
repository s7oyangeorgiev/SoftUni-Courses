
double sumWeHave = double.Parse(Console.ReadLine());
char sex = char.Parse(Console.ReadLine());
int ages = int.Parse(Console.ReadLine());
string sport = Console.ReadLine();

double priceForCard = 0;

if (sex == 'm')
{
    switch (sport)
    {
        case "Gym": priceForCard = 42; break;
        case "Boxing": priceForCard = 41; break;
        case "Yoga": priceForCard = 45; break;
        case "Zumba": priceForCard = 34; break;
        case "Dances": priceForCard = 51; break;
        case "Pilates": priceForCard = 39; break;
    }
}
else if (sex == 'f')
{
    switch (sport)
    {
        case "Gym": priceForCard = 35; break;
        case "Boxing": priceForCard = 37; break;
        case "Yoga": priceForCard = 42; break;
        case "Zumba": priceForCard = 31; break;
        case "Dances": priceForCard = 53; break;
        case "Pilates": priceForCard = 37; break;
    }
}
if (ages <= 19)
{
    priceForCard *= 0.80;
}
if (sumWeHave > priceForCard)
{
    Console.WriteLine($"You purchased a 1 month pass for {sport}.");
}
else
{
    Console.WriteLine($"You don't have enough money! You need ${priceForCard - sumWeHave:f2} more.");
}