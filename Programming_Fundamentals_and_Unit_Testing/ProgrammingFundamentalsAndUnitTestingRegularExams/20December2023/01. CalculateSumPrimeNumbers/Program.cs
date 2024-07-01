int numberCount = int.Parse(Console.ReadLine());

int[] numbers = new int[numberCount];

for (int i = 0; i < numberCount; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

int sumOfPrimes = 0;
string primeNumbersList = "";

for (int i = 0; i < numberCount; i++)
{
    if (IsPrime(numbers[i]))
    {
        sumOfPrimes += numbers[i];
        primeNumbersList += numbers[i] + " ";
    }
}

Console.WriteLine(sumOfPrimes);
 
static bool IsPrime(int number)
{
    if (number <= 1)
        return false;
    if (number == 2)
        return true;
    if (number % 2 == 0)
        return false;

    int boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}