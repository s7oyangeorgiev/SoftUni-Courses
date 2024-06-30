string numArray = Console.ReadLine();

int[] numbers = numArray.Split(' ')
    .Select(int.Parse)
    .ToArray();

int middleIndex = numbers.Length / 2;

int middleElement1 = numbers[middleIndex - 1];
int middleElement2 = numbers[middleIndex];

double average = (middleElement1 + middleElement2) / 2.0;

Console.WriteLine($"{average:F2}");