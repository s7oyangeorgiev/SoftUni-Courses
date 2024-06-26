int num = int.Parse(Console.ReadLine());

int sum = 0;
int max = int.MinValue;

for (int i = 1; i <= num; i++)
{
    int numbers = int.Parse(Console.ReadLine());

    if (numbers > max)
    {
        max = numbers;
    }
    sum += numbers;
}
if (max == sum - max)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {max}");
}
else
{
    int diff = max - (sum - max);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(diff)}");
}
