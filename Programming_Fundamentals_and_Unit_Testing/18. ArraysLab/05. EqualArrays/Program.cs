int[] firstArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

bool isIdential = false;

for (int i = 0; i < firstArray.Length; i++)
{
    int firstArrayCurrentNumber = firstArray[i];
    int secondArrayCurrentNumber = secondArray[i];

    if (firstArrayCurrentNumber == secondArrayCurrentNumber)
    {
        isIdential = true;
        continue;
    }
    else
    {
        isIdential = false;
        break;
    }
   
}

if (isIdential)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
