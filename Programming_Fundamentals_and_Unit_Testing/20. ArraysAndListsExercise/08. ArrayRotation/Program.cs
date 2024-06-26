List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstElement = numbers[0];
    numbers.RemoveAt(0);
    numbers.Add(firstElement);
}
Console.WriteLine(string.Join(" ", numbers));