
string money = Console.ReadLine();

double sum = 0;

while (money != "NoMoreMoney")
{
    double currentMoney = double.Parse(money);

    if (currentMoney < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {currentMoney:f2}");
    sum += currentMoney;
    money = Console.ReadLine();
}
Console.WriteLine($"Total: {sum:f2}");