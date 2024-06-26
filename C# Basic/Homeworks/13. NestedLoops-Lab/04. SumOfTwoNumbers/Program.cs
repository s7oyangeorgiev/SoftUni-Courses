
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int combination = 0;
bool isMagic = false;

for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        combination++;

        if (i + j == magicNumber)
        {
            isMagic = true;
            Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
            break;
        }
    }

    if (isMagic)
    {
        break;
    }
}
if (!isMagic)
{
    Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
}
