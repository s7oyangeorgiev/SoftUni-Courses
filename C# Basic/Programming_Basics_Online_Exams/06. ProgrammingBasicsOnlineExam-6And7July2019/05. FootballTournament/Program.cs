
using System.Diagnostics;

string nameOfTeam = Console.ReadLine();
int gameCount = int.Parse(Console.ReadLine());

double points = 0;
double wGames = 0;
double dGames = 0;
double lGames = 0;

for (int i = 0; i < gameCount; i++)
{
    char result = char.Parse(Console.ReadLine());

    switch (result)
    {
        case 'W': points += 3; wGames++; break;
        case 'D': points ++; dGames++; break;
        case 'L': points += 0; lGames++; break;

    }

}
double percentWinnings = (wGames / gameCount) * 100;

if (gameCount == 0)
{
    Console.WriteLine($"{nameOfTeam} hasn't played any games during this season.");
}
else if (gameCount > 0)
{
    Console.WriteLine($"{nameOfTeam} has won {points} points during this season.");
    Console.WriteLine("Total stats:");
    Console.WriteLine($"## W: {wGames}");
    Console.WriteLine($"## D: {dGames}");
    Console.WriteLine($"## L: {lGames}");
    Console.WriteLine($"Win rate: {percentWinnings:f2}%");
}