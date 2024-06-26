List<decimal> numbers = Console.ReadLine()
    .Split(" ")
    .Select(decimal.Parse)
    .ToList();

bool sumOccurred = true;

while (sumOccurred)
{
    sumOccurred = false;
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        if (numbers[i] == numbers[i + 1])
        {
            numbers[i] += numbers[i + 1];
            numbers.RemoveAt(i + 1);
            sumOccurred = true;
            break;
        }
    }
}

Console.WriteLine(string.Join(" ", numbers));