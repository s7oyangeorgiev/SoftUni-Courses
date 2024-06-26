
string nums = Console.ReadLine();

int primeSum = 0;
int nonPrimeSum = 0;

while (nums != "stop")
{
    int currentNum = int.Parse(nums);


    if (currentNum < 0)
    {
        Console.WriteLine("Number is negative.");
        nums = Console.ReadLine();
        continue;
    }

    bool isPrime = true;

    for (int i = 2; i < currentNum; i++)
    {
        if (currentNum % i == 0)
        {
            isPrime = false;
            break; ;
        }
    }
    if (isPrime)
    {
        primeSum += currentNum;
    }
    else
    {
        nonPrimeSum += currentNum;
    }

    nums = Console.ReadLine();
}
Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");