
char lastSector = char.Parse(Console.ReadLine());
int rowInFirstSector = int.Parse(Console.ReadLine());
int playcesCounGorOddRow = int.Parse(Console.ReadLine());

int places = 0;
int placesCount = 0;

for (char i = 'A'; i <= lastSector; i++)
{
    if (i != 'A')
    {
        rowInFirstSector += 1;
    }

    for (int j = 1; j <= rowInFirstSector; j++)
    {
        if (j % 2 == 1)
        {
            places += playcesCounGorOddRow;
        }
        else
        {
            places += (playcesCounGorOddRow + 2);
        }
        for (char k = 'a'; k <= 'z'; k++)
        {
            if (places == 0)
            {
                break;
            }
            places--;

            Console.WriteLine($"{i}{j}{k}");
            placesCount++;
        }
    }
}
Console.WriteLine(placesCount);