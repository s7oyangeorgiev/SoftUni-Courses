
string actorName = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int evaluative = int.Parse(Console.ReadLine());

for (int i = 0; i < evaluative; i++)
{
    string evaluativeName = Console.ReadLine();
    double pointsFromEvaluative = double.Parse(Console.ReadLine());

    pointsFromAcademy += evaluativeName.Length * pointsFromEvaluative / 2;

    if (pointsFromAcademy > 1250.5)
    {
        break;
    }
}
if (pointsFromAcademy > 1250.5)
{
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFromAcademy:f1}!");
}
else
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - pointsFromAcademy:f1} more!");
}