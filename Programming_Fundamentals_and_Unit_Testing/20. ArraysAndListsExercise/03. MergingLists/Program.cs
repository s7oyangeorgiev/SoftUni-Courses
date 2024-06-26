List<int> firstSequence = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

List<int> secondSequence = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

List<int> resultList = new List<int>();

int minLength = Math.Min(firstSequence.Count, secondSequence.Count);

for (int i = 0; i < minLength; i++)
{
    resultList.Add(firstSequence[i]);
    resultList.Add(secondSequence[i]);
}

if (firstSequence.Count > minLength)
{
    resultList.AddRange(firstSequence.GetRange(minLength, firstSequence.Count - minLength));
}
else if (secondSequence.Count > minLength)
{
    resultList.AddRange(secondSequence.GetRange(minLength, secondSequence.Count - minLength));
}

Console.WriteLine(string.Join(" ", resultList));