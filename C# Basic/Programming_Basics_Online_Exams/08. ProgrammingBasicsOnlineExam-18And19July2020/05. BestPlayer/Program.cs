
string nameOfPlayer = Console.ReadLine();

string hatTrickPlayer = "";
double maxGoals = double.MinValue;
string bestPlayer = "";
bool isHead = false;

while (nameOfPlayer != "END")
{
    int goals = int.Parse(Console.ReadLine());

    if (goals >= 3)
    {
        isHead = true;

        if (goals > maxGoals)
        {
            maxGoals = goals;
            hatTrickPlayer = nameOfPlayer;
        }
    }
    else if (goals > maxGoals)
    {
        bestPlayer = nameOfPlayer;
        maxGoals = goals;
    }
    if (goals >= 10)
    {
        break;
    }

    nameOfPlayer = Console.ReadLine();
}

if (isHead)
{
    Console.WriteLine($"{hatTrickPlayer} is the best player!");
    Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
}
else
{
    Console.WriteLine($"{bestPlayer} is the best player!");
    Console.WriteLine($"He has scored {maxGoals} goals.");
}
