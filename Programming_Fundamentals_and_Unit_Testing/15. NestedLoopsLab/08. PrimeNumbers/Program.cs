int startOfTheRange = int.Parse(Console.ReadLine());
int endOfTheRange = int.Parse(Console.ReadLine());

for  (int number = startOfTheRange; number <= endOfTheRange; number++)
{
    bool isPrime = true;

    for (int i = 2; i < number; i++)
    {
        if ( number % i == 0)
        {
            isPrime = false;
        }
    }
    if (isPrime)
    {
        Console.Write($"{number} ");
    }
}

