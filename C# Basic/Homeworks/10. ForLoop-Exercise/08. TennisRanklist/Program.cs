
int tournaments = int.Parse(Console.ReadLine());
double startingPoints = double.Parse(Console.ReadLine());

double averagePoints = 0;
double winTour = 0;

for (int i = 0; i < tournaments; i++)
{
    string stage = Console.ReadLine();

    if (stage == "W")
    {
        averagePoints += 2000;
        startingPoints += 2000;
        winTour++;
    }
    else if (stage == "F")
    {
        averagePoints += 1200;
        startingPoints += 1200;
    }
    else if (stage == "SF")
    {
        averagePoints += 720;
        startingPoints += 720;
    }
}
averagePoints = averagePoints / tournaments;

Console.WriteLine($"Final points: {startingPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{(winTour / tournaments) * 100:f2}%");

