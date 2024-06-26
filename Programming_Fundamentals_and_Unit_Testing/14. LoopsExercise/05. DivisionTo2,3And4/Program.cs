int numCount = int.Parse(Console.ReadLine());

double divisibleBy2 = 0;
double divisibleBy3 = 0;
double divisibleBy4 = 0;

for (int i = 1; i <= numCount; i++)
{
    int num = int.Parse(Console.ReadLine());

    if ( num % 2 == 0)
    {
        divisibleBy2 += 1;
    }
    if ( num % 3 == 0)
    {
        divisibleBy3 += 1;
    }
    if ( num % 4 == 0)
    {
        divisibleBy4 += 1;
    }
}

double divisibleBy2Percent = divisibleBy2 / numCount * 100.00;
double divisibleBy3Percent = divisibleBy3 / numCount * 100.00;
double divisibleBy4Percent = divisibleBy4 / numCount * 100.00;

Console.WriteLine($"{divisibleBy2Percent:f2}%");
Console.WriteLine($"{divisibleBy3Percent:f2}%");
Console.WriteLine($"{divisibleBy4Percent:f2}%");
