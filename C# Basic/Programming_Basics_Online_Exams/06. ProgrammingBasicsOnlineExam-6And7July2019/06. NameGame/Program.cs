
int points = 0;
int maxPoints = int.MinValue;
string winner = "";

while (true)
{
    string nameOfPlayer = Console.ReadLine();
    points = 0;

    if (nameOfPlayer == "Stop")
    {
        break;
    }

    for (int i = 0; i < nameOfPlayer.Length; i++)
    {
        char character = nameOfPlayer[i];
        int number = int.Parse(Console.ReadLine());

        if (number == (int)character)
        {
            points += 10;
        }
        else
        {
            points += 2;
        }
    }
    if (points >= maxPoints)
    {
        maxPoints = points;
        winner = nameOfPlayer;
    }

}
Console.WriteLine($"The winner is {winner} with {maxPoints} points!");