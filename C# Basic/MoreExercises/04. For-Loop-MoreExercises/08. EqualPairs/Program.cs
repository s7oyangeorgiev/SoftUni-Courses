
int num = int.Parse(Console.ReadLine());

int sumOne = 0;
int sumTwo = 0;
int diff = 0;

for (int i = 0; i < num; i++)
{
    int currentNumOne = int.Parse(Console.ReadLine());
    int currentNumTwo = int.Parse(Console.ReadLine());

    int sumOfNumbers = currentNumOne + currentNumTwo;

    if (i > 0)
    {
        int diffBetweenCycles = Math.Abs(sumOfNumbers - (sumOne + sumTwo));

        if (diffBetweenCycles > diff)
        {
            diff = diffBetweenCycles;
        }
    }
    sumOne = currentNumOne;
    sumTwo = currentNumTwo;
}
if (diff == 0)
{
    Console.WriteLine($"Yes, value={sumOne + sumTwo}");
}
else
{
    Console.WriteLine($"No, maxdiff={diff}");
}
