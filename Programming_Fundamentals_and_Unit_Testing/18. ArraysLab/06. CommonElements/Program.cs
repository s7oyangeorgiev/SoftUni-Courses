int[] firstArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i <= firstArray.Length - 1; i++)
{
    int currentNumInFirstArray = firstArray[i];

    foreach (int number in secondArray)
    {
        int currentNumberInSecondArray = number;

        if ( currentNumInFirstArray == number)
        {
            Console.Write(currentNumInFirstArray + " ");
        }
    }
}
Console.WriteLine();

