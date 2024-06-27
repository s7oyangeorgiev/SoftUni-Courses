
double sum = 0;
double maxValue = double.MinValue;
string mostPowerfullWord = "";

while (true)
{
    string command = Console.ReadLine();
    sum = 0;

    if (command == "End of words")
    {
        break;
    }

    for (int i = 0; i < command.Length; i++)
    {
        int currentNumber = (int)command[i];
        sum += currentNumber;
    }

    if (command[0] == 'a' || command[0] == 'e' || command[0] == 'i' || command[0] == 'o' ||
        command[0] == 'u' || command[0] == 'y' || command[0] == 'A' || command[0] == 'E' ||
        command[0] == 'I' || command[0] == 'O' || command[0] == 'U' || command[0] == 'Y')
    {
        sum *= command.Length;
    }
    else
    {
        sum /= command.Length;
        sum = Math.Round(sum);
    }

    if (sum > maxValue)
    {
        maxValue = sum;
        mostPowerfullWord = command;
    }
}
Console.WriteLine($"The most powerful word is {mostPowerfullWord} - {maxValue}");