
string number = Console.ReadLine();

int minNumber = int.MaxValue;

while (number != "Stop")
{
    int currentNumber = int.Parse(number);

    if (currentNumber < minNumber)
    {
        minNumber = currentNumber;
    }
    number = Console.ReadLine();
}
Console.WriteLine(minNumber);
