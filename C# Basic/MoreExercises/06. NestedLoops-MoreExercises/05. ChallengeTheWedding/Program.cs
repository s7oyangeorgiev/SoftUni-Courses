
int mansCount = int.Parse(Console.ReadLine());
int womanCount = int.Parse(Console.ReadLine());
int maximumTables = int.Parse(Console.ReadLine());

for (int j = 1; j <= mansCount; j++)
{
    for (int k = 1; k <= womanCount; k++)
    {
        if (maximumTables <= 0)
        {
            break;
        }
        Console.Write($"({j} <-> {k}) ");
        maximumTables--;

    }
}