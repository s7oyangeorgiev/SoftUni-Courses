
int easterBreadCount = int.Parse(Console.ReadLine());

int onePackOfShugar = 950;
int onePackOfFlour = 750;
int shugarNeeded = 0;
int flourNeeded = 0;

int maxCountOfShugar = int.MinValue;
int maxCountOfFlour = int.MinValue;

for (int i = 0; i < easterBreadCount; i++)
{
    int shugarCount = int.Parse(Console.ReadLine());

    if (shugarCount > maxCountOfShugar)
    {
        maxCountOfShugar = shugarCount;
    }
    int flourCount = int.Parse(Console.ReadLine());

    if (flourCount > maxCountOfFlour)
    {
        maxCountOfFlour = flourCount;
    }
    shugarNeeded += shugarCount;
    flourNeeded += flourCount;
}
double tottalPacksOfShugar = Math.Ceiling((double)shugarNeeded / onePackOfShugar);
double tottalFlour = Math.Ceiling((double)flourNeeded / onePackOfFlour);

Console.WriteLine($"Sugar: {tottalPacksOfShugar}");
Console.WriteLine($"Flour: {tottalFlour}");
Console.WriteLine($"Max used flour is {maxCountOfFlour} grams, max used sugar is {maxCountOfShugar} grams.");