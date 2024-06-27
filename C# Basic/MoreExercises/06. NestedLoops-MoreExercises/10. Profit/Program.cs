int coinsFrom1Count = int.Parse(Console.ReadLine());
int coinsFrom2Count = int.Parse(Console.ReadLine());
int moneyFrom5Count = int.Parse(Console.ReadLine());
int sum = int.Parse(Console.ReadLine());

for (int i = 0; i <= coinsFrom1Count; i++)
{
    for (int j = 0; j <= coinsFrom2Count; j++)
    {
        for (int k = 0; k <= moneyFrom5Count; k++)
        {
            int currentSum = i * 1 + j * 2 + k * 5;

            if (currentSum == sum)
            {
                Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
            }
        }
    }
}
