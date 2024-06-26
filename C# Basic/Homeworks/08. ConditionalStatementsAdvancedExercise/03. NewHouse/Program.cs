string flowers = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double rosesPrice = 5;
double dahliasPrice = 3.80;
double tulipsPrice = 2.80;
double narcissusPrice = 3;
double gladiolusPrice = 2.50;

if (flowers == "Roses")
{
    if (flowerCount > 80)
    {
        rosesPrice = (flowerCount * rosesPrice) * 0.90;
    }
    else
    {
        rosesPrice = flowerCount * rosesPrice;
    }
    if (budget < rosesPrice)
    {
        Console.WriteLine($"Not enough money, you need {rosesPrice - budget:f2} leva more."); 
    }
    else
    {
        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowers} and {budget - rosesPrice:f2} leva left.");
    }
}
else if (flowers == "Dahlias")
{
    if (flowerCount > 90)
    {
        dahliasPrice = (flowerCount * dahliasPrice) * 0.85;
    }
    else
    {
        dahliasPrice = flowerCount * dahliasPrice;
    }
    if (budget < dahliasPrice)
    {
        Console.WriteLine($"Not enough money, you need {dahliasPrice - budget:f2} leva more.");
    }
    else
    {
        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowers} and {budget - dahliasPrice:f2} leva left.");
    }
}
else if (flowers == "Tulips")
{
    if (flowerCount > 80)
    {
        tulipsPrice = (flowerCount * tulipsPrice) * 0.85;
    }
    else
    {
        tulipsPrice = flowerCount * tulipsPrice;
    }
    if (budget < tulipsPrice)
    {
        Console.WriteLine($"Not enough money, you need {tulipsPrice - budget:f2} leva more.");
    }
    else
    {
        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowers} and {budget - tulipsPrice:f2} leva left.");
    }
}
else if (flowers == "Narcissus")
{
    if (flowerCount < 120)
    {
        narcissusPrice = (flowerCount * narcissusPrice) * 1.15;
    }
    else
    {
        narcissusPrice = flowerCount * narcissusPrice;
    }
    if (budget < narcissusPrice)
    {
        Console.WriteLine($"Not enough money, you need {narcissusPrice - budget:f2} leva more.");
    }
    else
    {
        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowers} and {budget - narcissusPrice:f2} leva left.");
    }
}
else if (flowers == "Gladiolus")
{
    if (flowerCount < 80)
    {
        gladiolusPrice = (flowerCount * gladiolusPrice) * 1.20;
    }
    else
    {
        gladiolusPrice = flowerCount * gladiolusPrice;
    }
    if (budget < gladiolusPrice)
    {
        Console.WriteLine($"Not enough money, you need {gladiolusPrice - budget:f2} leva more.");
    }
    else
    {
        Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowers} and {budget - gladiolusPrice:f2} leva left.");
    }
}