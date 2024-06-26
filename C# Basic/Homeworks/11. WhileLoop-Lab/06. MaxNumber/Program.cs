
string number = Console.ReadLine();

int maxNumber = int.MinValue;

while (number != "Stop")
{
    int currentNumber = int.Parse(number);

    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber;
    }
    number = Console.ReadLine();
}
Console.WriteLine(maxNumber);