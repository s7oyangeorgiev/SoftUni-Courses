
int days = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double tottalPrice = 0;

for (int i = 1; i <= days; i++)
{
    double price = 0;
    for (int j = 1; j <= hours; j++)
    {
        if (i % 2 == 0 && j % 2 == 1)
        {
            price += 2.50;
            tottalPrice += 2.50;
        }
        else if (j % 2 == 0 && i % 2 == 1)
        {
            price += 1.25;
            tottalPrice += 1.25;
        }
        else
        {
            price += 1;
            tottalPrice += 1;
        }
    }
    
    Console.WriteLine($"Day: {i} - {price:f2} leva");

}
Console.WriteLine($"Total: {tottalPrice:f2} leva");