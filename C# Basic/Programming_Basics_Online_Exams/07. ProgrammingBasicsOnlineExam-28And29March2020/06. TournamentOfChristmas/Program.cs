
int daysCount = int.Parse(Console.ReadLine());

double profitForCharity = 0;
double tottalProfit = 0;
int winsCounter = 0;
int lostCounter = 0;
int winsDaysCounter = 0;
int lostDaysCounter = 0;

for (int i = 0; i < daysCount; i++)
{
    string nameOfGames = Console.ReadLine();
    profitForCharity = 0;

    while (nameOfGames != "Finish")
    {
        string result = Console.ReadLine();

        if (result == "win")
        {
            profitForCharity += 20;
            winsCounter++;
        }
        else
        {
            lostCounter++;
        }
        nameOfGames = Console.ReadLine();
    }

    if (winsCounter > lostCounter)
    {
        profitForCharity *= 1.10;
        tottalProfit += profitForCharity;
        winsDaysCounter++;
    }
    else
    {
        tottalProfit += profitForCharity;
        lostDaysCounter++;
    }
    winsCounter = 0;
    lostCounter = 0;
}
if (winsDaysCounter > lostDaysCounter)
{
    tottalProfit *= 1.20;
    Console.WriteLine($"You won the tournament! Total raised money: {tottalProfit:f2}");
}
else
{
    Console.WriteLine($"You lost the tournament! Total raised money: {tottalProfit:f2}");
}