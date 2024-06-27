
string nameOfFirstPlayer = Console.ReadLine();
string nameOfSecondPlayer = Console.ReadLine();

string numberWars = "";
string commandFirstPlayer = "";
string commandSecondPlayer = "";
int cardOfFirstPlayer = 0;
int cardOfSecondPlayer = 0;
int pointsOfFirstPlayer = 0;
int pointsOfSecondPlayer = 0;


while (true)
{
    commandFirstPlayer = Console.ReadLine();
    if (commandFirstPlayer == "End of game" || commandSecondPlayer == "End of game")
    {
        commandFirstPlayer = "End of game";
        break;
    }
    commandSecondPlayer = Console.ReadLine();
        if(commandFirstPlayer == "End of game" || commandSecondPlayer == "End of game")
    {
        commandSecondPlayer = "End of game";
        break;
    }
    else
    {
        cardOfFirstPlayer = int.Parse(commandFirstPlayer);
        cardOfSecondPlayer = int.Parse(commandSecondPlayer);

        if (cardOfFirstPlayer == cardOfSecondPlayer)
        {
            numberWars = "Number wars";
            cardOfFirstPlayer = int.Parse(Console.ReadLine());
            cardOfSecondPlayer = int.Parse(Console.ReadLine());

            if (cardOfFirstPlayer > cardOfSecondPlayer)
            {
                pointsOfSecondPlayer = 0;
            }
            else if (cardOfFirstPlayer < cardOfSecondPlayer)
            {
                pointsOfFirstPlayer = 0;
            }
            break;
        }
    }

    if (cardOfFirstPlayer > cardOfSecondPlayer)
    {
        pointsOfFirstPlayer += cardOfFirstPlayer - cardOfSecondPlayer;
    }
    else if (cardOfFirstPlayer < cardOfSecondPlayer)
    {
        pointsOfSecondPlayer += cardOfSecondPlayer - cardOfFirstPlayer;
    }
}
if (numberWars == "Number wars")
{
    Console.WriteLine("Number wars!");

    if (pointsOfFirstPlayer > pointsOfSecondPlayer)
    {
        Console.WriteLine($"{nameOfFirstPlayer} is winner with {pointsOfFirstPlayer} points");
    }
    else
    {
        Console.WriteLine($"{nameOfSecondPlayer} is winner with {pointsOfSecondPlayer} points");
    }
}
else if (commandFirstPlayer == "End of game" || commandSecondPlayer == "End of game")
{
    Console.WriteLine($"{nameOfFirstPlayer} has {pointsOfFirstPlayer} points");
    Console.WriteLine($"{nameOfSecondPlayer} has {pointsOfSecondPlayer} points");
}