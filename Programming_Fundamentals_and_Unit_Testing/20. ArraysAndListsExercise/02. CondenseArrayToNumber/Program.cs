List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

while (numbers.Count > 1)
{
    List<int> condensed = new List<int>();

    for (int i = 0; i < numbers.Count - 1; i++)
    {
        condensed.Add(numbers[i] + numbers[i + 1]);
    }

    numbers = condensed;
}
Console.WriteLine(numbers[0]);