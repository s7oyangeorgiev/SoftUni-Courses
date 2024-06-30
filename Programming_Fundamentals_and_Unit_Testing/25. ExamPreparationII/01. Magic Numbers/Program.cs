int number = int.Parse(Console.ReadLine());

string magicNumbers = "";

for (int num = 1; num <= number; num++)
{
    if (IsMagicNumber(num))
    {
        if (magicNumbers.Length > 0)
            magicNumbers += " ";
        magicNumbers += num.ToString();
    }
}

if (magicNumbers.Length > 0)
    Console.WriteLine(magicNumbers);
else
    Console.WriteLine("no");

// Method to check if a number is a magic number
static bool IsMagicNumber(int num)
{
    bool allPrime = true;
    int sumOfDigits = 0;

    string numStr = num.ToString();

    foreach (char digit in numStr)
    {
        int digitValue = (int)(digit - '0'); // Convert char to int

        if (!IsPrime(digitValue))
        {
            allPrime = false;
            break;
        }

        sumOfDigits += digitValue;
    }

    return allPrime && (sumOfDigits % 2 == 0);
}

// Method to check if a number is prime
static bool IsPrime(int num)
{
    if (num <= 1)
        return false;
    if (num == 2)
        return true;
    if (num % 2 == 0)
        return false;

    int sqrt = (int)Math.Sqrt(num);
    for (int i = 3; i <= sqrt; i += 2)
    {
        if (num % i == 0)
            return false;
    }

    return true;
}