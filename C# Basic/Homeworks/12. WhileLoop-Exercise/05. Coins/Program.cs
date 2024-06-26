
decimal sum = decimal.Parse(Console.ReadLine());

int coinCounter = 0;

while (sum > 0)
{
    if (sum >= 2m)
    {
        sum -= 2m;
        coinCounter++;
    }
    else if (sum >= 1m)
    {
        sum -= 1m;
        coinCounter++;
    }
    else if (sum >= 0.50m)
    {
        sum -= 0.50m;
        coinCounter++;
    }
    else if (sum >= 0.20m)
    {
        sum -= 0.20m;
        coinCounter++;
    }
    else if (sum >= 0.10m)
    {
        sum -= 0.10m;
        coinCounter++;
    }
    else if (sum >= 0.05m)
    {
        sum -= 0.05m;
        coinCounter++;
    }
    else if (sum >= 0.02m)
    {
        sum -= 0.02m;
        coinCounter++;
    }
    else
    {
        sum -= 0.01m;
        coinCounter++;
    }
}
Console.WriteLine(coinCounter);