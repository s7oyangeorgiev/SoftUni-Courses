
string nameOfActor = Console.ReadLine();
double pointsFromAccademy = double.Parse(Console.ReadLine());
int juryCount = int.Parse(Console.ReadLine());

double pointsForActorFromJury = 0;

for (int i = 0; i < juryCount; i++)
{
    string nameOfJury = Console.ReadLine();
    int lenght = nameOfJury.Length;
    double pointsFromJury = double.Parse(Console.ReadLine());

    pointsForActorFromJury += ((double)lenght * pointsFromJury) / 2;

    if ((pointsFromAccademy + pointsForActorFromJury) > 1250.5)
    {
        break;
    }
}


if ((pointsFromAccademy + pointsForActorFromJury) > 1250.5)
{
    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {pointsFromAccademy + pointsForActorFromJury:f1}!");
}
else
{
    Console.WriteLine($"Sorry, {nameOfActor} you need {(1250.5 - (pointsFromAccademy + pointsForActorFromJury)):f1} more!");
}