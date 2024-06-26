int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int oddSum = 0;
int evenSum = 0;


foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}

int sumDifference = (evenSum - oddSum);
Console.WriteLine(sumDifference);



