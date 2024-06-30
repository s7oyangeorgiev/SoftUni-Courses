string num = Console.ReadLine();

int sumOfFactorials = 0;

foreach (char chars in num)
{
    int digit = chars - '0';

    if (digit % 2 == 0)
    {
        int factorial = Factorial(digit);

        sumOfFactorials += factorial;
    }
}

Console.WriteLine(sumOfFactorials);

static int Factorial(int n)
{
    if (n == 0 || n == 1)
        return 1;

    int result = 1;

    for (int i = n; i > 1; i--)
    {
        result *= i;
    }
    return result;
}

