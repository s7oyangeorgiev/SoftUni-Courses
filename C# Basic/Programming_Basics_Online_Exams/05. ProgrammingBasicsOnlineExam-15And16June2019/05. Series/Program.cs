
double budget = double.Parse(Console.ReadLine());
int serialsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < serialsCount; i++)
{
    string nameOfSerial = Console.ReadLine();
    double priceOfSerial = double.Parse(Console.ReadLine());

    switch (nameOfSerial)
    {
        case "Thrones": priceOfSerial *= 0.50; break;
        case "Lucifer": priceOfSerial *= 0.60; break;
        case "Protector": priceOfSerial *= 0.70; break;
        case "TotalDrama": priceOfSerial *= 0.80; break;
        case "Area": priceOfSerial *= 0.90; break;
    }

    budget -= priceOfSerial;

}
if (budget >= 0)
{
    Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
}
else
{
    Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");
}