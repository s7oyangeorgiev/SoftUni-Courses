
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int combination = 0;
bool isCombination = false;

for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        combination++;
        if ( i + j == magicNum)
        {
            isCombination = true;
            Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNum})");
            break;
        }
    }
    if (isCombination)
    {
        break; ;
    }
}
if (!isCombination)
{
    Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
}

