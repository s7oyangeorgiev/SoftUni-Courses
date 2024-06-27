
string nameOfPlayer = Console.ReadLine();

int maxGoals = int.MinValue;
string bestPlayer = "";
bool isHed = false;

while (nameOfPlayer != "END")
{
    int goals = int.Parse(Console.ReadLine());

    if (goals >= 3)
    {
        isHed = true;
    }
    if (goals > maxGoals)
    {
        maxGoals = goals;
        bestPlayer = nameOfPlayer;
    }
    if (goals >= 10)
    {
        break;
    }
    nameOfPlayer = Console.ReadLine();
}
Console.WriteLine($"{bestPlayer} is the best player!");

if (isHed)
{
    Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
}
else
{
    Console.WriteLine($"He has scored {maxGoals} goals.");
}