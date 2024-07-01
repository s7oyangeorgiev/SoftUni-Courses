
int[] numArray = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int lastElement = numArray[numArray.Length - 1];

    for (int j = numArray.Length - 1; j > 0; j--)
    {
        numArray[j] = numArray[j - 1];
    }
    numArray[0] = lastElement;
}

Console.WriteLine(string.Join(", ", numArray));