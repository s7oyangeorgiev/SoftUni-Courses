
int days = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double price = 0;
double tottalPrice = 0;

for (int i = 1; i <= days; i++)
{
    for (int j = 1; j <= hours; j++)
    {
        if (i % 2 == 1 && j % 2 == 0)
        {
            price += 1.25;
        }
        else if (i % 2 == 0 && j % 2 == 1)
        {
            price += 2.50;
        }
        else
        {
            price += 1.00;
        }
    }
    Console.WriteLine($"Day: {i} - {price:f2} leva");
    tottalPrice += price;
    price = 0;
}
Console.WriteLine($"Total: {tottalPrice:f2} leva");

