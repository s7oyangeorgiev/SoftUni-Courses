int[] array = Console.ReadLine()
                      .Split(' ')
                      .Select(int.Parse)
                      .ToArray();

int num = int.Parse(Console.ReadLine());

int maxNumber = FindMaxInFirstN(array, num);
int minNumber = FindMinInFirstN(array, num);

Console.WriteLine(maxNumber);
Console.WriteLine(minNumber);

static int FindMaxInFirstN(int[] array, int N)
{
    return array.Take(N).Max();
}

static int FindMinInFirstN(int[] array, int N)
{
    return array.Take(N).Min();
}