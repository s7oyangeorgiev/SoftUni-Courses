
int num = int.Parse(Console.ReadLine());

double points = 0;
int redBallsCounter = 0;
int orangeBallsCounter = 0;
int yellowBallsCounter = 0;
int whiteBallsCounter = 0;
int blackBallsCounter = 0;
int othersBallsCounter = 0;

for (int i = 0; i < num; i++)
{
    string color = Console.ReadLine();

    switch (color)
    {
        case "red": points += 5; redBallsCounter++; break;
        case "orange": points += 10; orangeBallsCounter++; break;
        case "yellow": points += 15; yellowBallsCounter++; break;
        case "white": points += 20; whiteBallsCounter++; break;
        case "black": points = Math.Floor(points / 2); blackBallsCounter++; break;
    }
    if (color != "red" && color != "orange" && color != "yellow" && color != "white" && color != "black")
    {
        othersBallsCounter++;
    }
}
double tottalPoints = num + points;

Console.WriteLine($"Total points: {points}");
Console.WriteLine($"Red balls: {redBallsCounter}");
Console.WriteLine($"Orange balls: {orangeBallsCounter}");
Console.WriteLine($"Yellow balls: {yellowBallsCounter}");
Console.WriteLine($"White balls: {whiteBallsCounter}");
Console.WriteLine($"Other colors picked: {othersBallsCounter}");
Console.WriteLine($"Divides from black balls: {blackBallsCounter}");
