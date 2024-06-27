
double computerCount = double.Parse(Console.ReadLine());

double prodajbi = 0;
double tottalRaiting = 0;
double tottal = 0;
double tottalSells = 0;

for (double i = 1; i <= computerCount; i++)
{
    double sellsAndReiting = double.Parse(Console.ReadLine());
    
    double rating = sellsAndReiting % 10;
    double newSum = Math.Round(sellsAndReiting - rating) / 10;
    tottalRaiting += rating;
    
    if (rating <= 2)
    {
        tottalSells = newSum * 0;
    }
    else if (rating == 3)
    {
        tottalSells = newSum * 0.50;
    }
    else if (rating == 4)
    {
        tottalSells = newSum * 0.70;
    }
    else if (rating == 5)
    {
        tottalSells = newSum * 0.85;
    }
    else if (rating >= 6)
    {
        tottalSells = newSum * 1.0;
    }

    tottal += tottalSells;
}
Console.WriteLine($"{tottal:f2}");
Console.WriteLine($"{tottalRaiting / computerCount:f2}");