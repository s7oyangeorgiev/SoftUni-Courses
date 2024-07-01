int[] numArray = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int nums = int.Parse(Console.ReadLine());

bool foundAny = false;

foreach (int num in numArray)
{
    if (num > nums)
    {
        if (foundAny)
        {
            Console.Write($" {num}");
        }
        else
        {
            Console.Write($"{num}");
            foundAny = true;
        }
    }
}

Console.WriteLine();