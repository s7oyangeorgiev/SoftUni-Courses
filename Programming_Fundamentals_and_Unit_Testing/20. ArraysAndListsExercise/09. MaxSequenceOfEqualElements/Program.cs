List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int longestSequenceStart = 0;
int longestSequenceLength = 1;

int currentSequenceStart = 0;
int currentSequenceLength = 1;

for (int i = 1; i < numbers.Count; i++)
{
    if (numbers[i] == numbers[i - 1])
    {
        currentSequenceLength++;
    }
    else
    {
        if (currentSequenceLength > longestSequenceLength)
        {
            longestSequenceLength = currentSequenceLength;
            longestSequenceStart = currentSequenceStart;
        }

        currentSequenceStart = i;
        currentSequenceLength = 1;
    }
}

if (currentSequenceLength > longestSequenceLength)
{
    longestSequenceLength = currentSequenceLength;
    longestSequenceStart = currentSequenceStart;
}

for (int i = 0; i < longestSequenceLength; i++)
{
    Console.Write(numbers[longestSequenceStart] + " ");
}