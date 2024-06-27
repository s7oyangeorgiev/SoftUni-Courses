
string resultFromFirstGame = Console.ReadLine();
string resultFromSecondGame = Console.ReadLine();
string resultFromThirdGame = Console.ReadLine();

int wins = 0;
int losts = 0;
int drowns = 0;

if (resultFromFirstGame[0] > resultFromFirstGame[2])
{
    wins += 1;
}
else if (resultFromFirstGame[0] < resultFromFirstGame[2])
{
    losts += 1;
}
else
{
    drowns += 1;
}
if (resultFromSecondGame[0] > resultFromSecondGame[2])
{
    wins += 1;
}
else if (resultFromSecondGame[0] < resultFromSecondGame[2])
{
    losts += 1;
}
else
{
    drowns += 1;
}
if (resultFromThirdGame[0] > resultFromThirdGame[2])
{
    wins += 1;
}
else if (resultFromThirdGame[0] < resultFromThirdGame[2])
{
    losts += 1;
}
else
{
    drowns += 1;
}

Console.WriteLine($"Team won {wins} games.");
Console.WriteLine($"Team lost {losts} games.");
Console.WriteLine($"Drawn games: {drowns}");
