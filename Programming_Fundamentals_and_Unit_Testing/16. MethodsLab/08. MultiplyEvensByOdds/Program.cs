int num = Math.Abs(int.Parse(Console.ReadLine()));
int result = GetMultipleOfEvenAndOdds(num);
Console.WriteLine(result);

static int GetMultipleOfEvenAndOdds(int num)
{
    return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
}

static int GetSumOfEvenDigits(int num)
{
    int evenSum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        num /= 10;

        if (digit % 2 == 0)
        {
            evenSum += digit;
        }
    }
    return evenSum;
}

static int GetSumOfOddDigits(int num)
{
    int oddSum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        num /= 10;

        if (digit % 2 == 1)
        {
            oddSum += digit;
        }
    }
    return oddSum;
}