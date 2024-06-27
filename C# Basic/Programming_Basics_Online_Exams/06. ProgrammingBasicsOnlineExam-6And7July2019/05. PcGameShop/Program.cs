
int sellingGamesCount = int.Parse(Console.ReadLine());

int hearthstoneCount = 0;
int forniteCount = 0;
int overwatchCount = 0;
int othersCount = 0;

for (int i = 0; i < sellingGamesCount; i++)
{
    string nameOfTheGame = Console.ReadLine();

    switch (nameOfTheGame)
    {
        case "Hearthstone": hearthstoneCount++; break;
        case "Fornite": forniteCount++; break;
        case "Overwatch": overwatchCount++; break;
    }
    if (nameOfTheGame != "Hearthstone" && nameOfTheGame != "Fornite" && nameOfTheGame != "Overwatch")
    {
        othersCount++;
    }
}

double percentHearthstone = ((double)hearthstoneCount / sellingGamesCount) * 100;
double percentFornite = ((double)forniteCount / sellingGamesCount) * 100;
double percentOverwatch = ((double)overwatchCount / sellingGamesCount) * 100;
double percentOthers = ((double)othersCount / sellingGamesCount) * 100;

Console.WriteLine($"Hearthstone - {percentHearthstone:f2}%");
Console.WriteLine($"Fornite - {percentFornite:f2}%");
Console.WriteLine($"Overwatch - {percentOverwatch:f2}%");
Console.WriteLine($"Others - {percentOthers:f2}%");
