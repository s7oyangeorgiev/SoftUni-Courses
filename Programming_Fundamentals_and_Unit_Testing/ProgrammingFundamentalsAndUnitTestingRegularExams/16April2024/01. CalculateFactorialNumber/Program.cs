int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    int number = int.Parse(Console.ReadLine());
    int factorial = CalculateFactorial(number);
    Console.WriteLine(factorial);
}
    static int CalculateFactorial(int num)
{
    if (num < 0)
    {
        return -1;
    }

    int result = 1;

    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }

    return result;
}