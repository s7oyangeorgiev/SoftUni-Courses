string incomesOrExpenses = Console.ReadLine();

double balance = 0;

while (incomesOrExpenses != "End")
{
    double num = double.Parse(incomesOrExpenses);

    if (num >= 0)
    {
        Console.WriteLine($"Increase: {num:f2}");
        balance += num;
    }
    else
    {
        Console.WriteLine($"Decrease: {num * -1:f2}");
        balance += num;
    }

    incomesOrExpenses = Console.ReadLine();

}

Console.WriteLine($"Balance: {balance:f2}");