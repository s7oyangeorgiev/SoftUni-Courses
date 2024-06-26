int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());

int totalDevideFactorialResult = TotalFactorialsDevide(numOne,numTwo);
Console.WriteLine(totalDevideFactorialResult);




static int TotalFactorialsDevide(int numOne, int numTwo)
{
    int result = FirstFactorial(numOne) / SecondFactorial(numTwo);
    return result;
}
static int FirstFactorial(int numOne)
{
    int result = 1;
    for (int i = numOne; i >= 1; i--)
    {
        result *= i;
    }
    return result;
}

static int SecondFactorial(int numTwo)
{
    int result = 1;
    for (int i = numTwo; i >= 1; i--)
    {
        result *= i;
    }
    return result;
}