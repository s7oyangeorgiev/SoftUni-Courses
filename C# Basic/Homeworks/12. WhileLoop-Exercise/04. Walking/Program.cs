
int stepsPerDayToDo = 10_000;
int tottalStepsPerDay = 0;

while (true)
{
    string currentSteps = Console.ReadLine();

    if (currentSteps == "Going home")
    {
        int stepsToHome = int.Parse(Console.ReadLine());
        tottalStepsPerDay += stepsToHome;
        break;
    }
    else
    {
        int steps = int.Parse(currentSteps);
        tottalStepsPerDay += steps;

        if (tottalStepsPerDay >= stepsPerDayToDo)
        {
            break;
        }
    }
}
if (tottalStepsPerDay >= stepsPerDayToDo)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{tottalStepsPerDay - stepsPerDayToDo} steps over the goal!");
}
else
{
    Console.WriteLine($"{stepsPerDayToDo - tottalStepsPerDay} more steps to reach goal.");
}