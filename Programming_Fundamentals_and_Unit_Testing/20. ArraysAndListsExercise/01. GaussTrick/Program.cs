List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

List<int> sums = new List<int>();

for (int i = 0; i < numbers.Count / 2; i++)
{
    int sum = numbers[i] + numbers[numbers.Count - 1 - i];
    sums.Add(sum);
}

if (numbers.Count % 2 != 0)
{
    sums.Add(numbers[numbers.Count / 2]);
}
Console.WriteLine(string.Join(" ", sums));
