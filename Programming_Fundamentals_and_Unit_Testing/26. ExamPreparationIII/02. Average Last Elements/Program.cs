int[] array = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

int N = int.Parse(Console.ReadLine());

int startIndex = Math.Max(0, array.Length - N);
int[] lastNElements = array.Skip(startIndex).ToArray();

double average = lastNElements.Average();

Console.WriteLine($"{average:F2}");