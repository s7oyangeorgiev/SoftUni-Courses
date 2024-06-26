List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

List<int> topIntegers = new List<int>();

int maxNumber = int.MinValue;

for (int i = numbers.Count - 1; i >= 0; i--)
{
    if (numbers[i] > maxNumber)
    {
        topIntegers.Add(numbers[i]);
        maxNumber = numbers[i];
    }
}

topIntegers.Reverse();

Console.WriteLine(string.Join(" ", topIntegers));