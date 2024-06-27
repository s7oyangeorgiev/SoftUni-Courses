
int tournamentsCount = int.Parse(Console.ReadLine());
int stratingPointsRangList = int.Parse(Console.ReadLine());

int points = 0;
int winTournaments = 0;

for (int i = 0; i < tournamentsCount; i++)
{
    string stageReached = Console.ReadLine();

    switch (stageReached)
    {
        case "W": points += 2_000; winTournaments++; break;
        case "F": points += 1_200; break;
        case "SF": points += 720; break;
    }
}
int tottalPoints = stratingPointsRangList + points;
double avaragePoints = points / tournamentsCount;
double percentWinnings = ((double)winTournaments / tournamentsCount) * 100;

Console.WriteLine($"Final points: {tottalPoints}");
Console.WriteLine($"Average points: {avaragePoints}");
Console.WriteLine($"{percentWinnings:f2}%");

