
double moneyNeeded = double.Parse(Console.ReadLine());
double moneyOnHand = double.Parse(Console.ReadLine());

int spendCounter = 0;
int daysPast = 0;

while (true)
{
    string action = Console.ReadLine();
    double sum = double.Parse(Console.ReadLine());
    daysPast++;

    if (action == "spend" && sum > moneyOnHand)
    {
        moneyOnHand = 0;
    }
    else if (action == "spend")
    {
        spendCounter++;
        moneyOnHand -= sum;
    }
    else
    {
        spendCounter = 0;
        moneyOnHand += sum;
    }
    
    if (spendCounter == 5)
    {
        Console.WriteLine("You can't save the money.");
        Console.WriteLine($"{daysPast}");
        break;
    }
    else if (moneyOnHand >= moneyNeeded)
    {
        Console.WriteLine($"You saved the money for {daysPast} days.");
        break;
    }
}