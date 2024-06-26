
int floorsCount = int.Parse(Console.ReadLine());
int estatesCount = int.Parse(Console.ReadLine());

for (int floors = floorsCount; floors >= 1; floors--)
{
    for (int apartments = 0; apartments < estatesCount; apartments++)
    {
        if (floors == floorsCount)
        {
            Console.Write($"L{floors}{apartments} ");
            continue;
        }
        else if (floors % 2 == 1)
        {
            Console.Write($"A{floors}{apartments} ");
            continue;
        }
        else if (floors % 2 == 0)
        {
            Console.Write($"O{floors}{apartments} ");
            continue;
        }
    }
    Console.WriteLine();
}
