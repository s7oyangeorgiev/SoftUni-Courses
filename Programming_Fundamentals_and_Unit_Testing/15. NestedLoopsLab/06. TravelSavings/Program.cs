string destination = "";

while (destination != "End")
{
    destination = Console.ReadLine();

    if (destination == "End")
    {
        break;
    }

    int budgetNeeded = int.Parse(Console.ReadLine());
    int collectedMoney = 0;

    while (budgetNeeded > 0)
    {
        int currendBudget = int.Parse(Console.ReadLine());
        budgetNeeded -= currendBudget;
        collectedMoney += currendBudget;
        Console.WriteLine($"Collected: {collectedMoney:f2}");

    }
    Console.WriteLine($"Going to {destination}!");
    collectedMoney = 0;
}
