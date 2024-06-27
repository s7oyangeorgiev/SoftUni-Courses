
string nameOfTournament = Console.ReadLine();

int gameCounter = 0;
int tottalGamesCounter = 0;
int winsCounter = 0;
int lostCounter = 0;

while (nameOfTournament != "End of tournaments")
{
    int gamesCount = int.Parse(Console.ReadLine());

    for (int i = 0; i < gamesCount; i++)
    {
        int pointsForDesiTeam = int.Parse(Console.ReadLine());
        int pointForOtherTeam = int.Parse(Console.ReadLine());
        gameCounter++;
        tottalGamesCounter++;

        if (pointsForDesiTeam > pointForOtherTeam)
        {
            winsCounter++;
            Console.WriteLine($"Game {gameCounter} of tournament {nameOfTournament}: " +
                $"win with {pointsForDesiTeam - pointForOtherTeam} points.");
            continue;
        }
        else
        {
            lostCounter++;
            Console.WriteLine($"Game {gameCounter} of tournament {nameOfTournament}: " +
                $"lost with {pointForOtherTeam - pointsForDesiTeam} points.");
            continue;
        }
    }
    gameCounter = 0;
    nameOfTournament = Console.ReadLine();
}
if (nameOfTournament == "End of tournaments")
{
    Console.WriteLine($"{((double)winsCounter / tottalGamesCounter) * 100:f2}% matches win");
    Console.WriteLine($"{((double)lostCounter / tottalGamesCounter) * 100:f2}% matches lost");
}