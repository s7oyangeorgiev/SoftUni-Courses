string product = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double result = TotalPrice(product, quantity);
Console.WriteLine($"{result:f2}");

static double TotalPrice(string product, double quantity)
{
    double totalPrice = 0;
    switch (product)
    {
        case "coffee": totalPrice = quantity * 1.50; break;
        case "water": totalPrice = quantity * 1.00; break;
        case "coke": totalPrice = quantity * 1.40; break;
        case "snacks": totalPrice = quantity * 2.00; break;
    }
    return totalPrice;
}