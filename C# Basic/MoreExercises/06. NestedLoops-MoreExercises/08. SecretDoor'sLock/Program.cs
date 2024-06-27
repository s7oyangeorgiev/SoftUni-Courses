
int ceilingFirstNum = int.Parse(Console.ReadLine());
int ceilingSecondNum =  int.Parse(Console.ReadLine());
int ceilingThirdNum = int.Parse(Console.ReadLine());

for (int i = 2; i <= ceilingFirstNum; i++)
{
    for (int j = 1; j <= ceilingSecondNum; j++)
    {
        if (j > 7)
        {
            break;
        }
        for (int k = 2; k <= ceilingThirdNum; k++)
        {
            if (i % 2 == 0 && k % 2 == 0)
            {
                for (int l = 2; l <= j; l++)
                {
                    if (j % l == 0 && j % 2 != 0)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                        break;
                    }
                    if (j == 2)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                        break;
                    }
                }
                
            }
        }
    }
}