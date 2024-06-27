
double budget = double.Parse(Console.ReadLine());

int productCount = 0;
double productPrice = 0;

while (true)
{
    string product = Console.ReadLine();

    if (product == "Stop")
    {
        Console.WriteLine($"You bought {productCount} products for {productPrice:f2} leva.");
        break;
    }

    double price = double.Parse(Console.ReadLine());
    productCount += 1;

    if (productCount % 3 == 0)
    {
        price *= 0.50;
    }
    if (price > budget)
    {
        Console.WriteLine("You don't have enough money!");
        Console.WriteLine($"You need {price - budget:f2} leva!");
        break;
    }
    productPrice += price;
    budget -= price;
}