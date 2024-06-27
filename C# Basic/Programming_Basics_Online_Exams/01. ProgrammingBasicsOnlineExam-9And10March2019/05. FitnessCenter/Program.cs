
int visitorsCount = int.Parse(Console.ReadLine());

int trainingBack = 0;
int trainingChest = 0;
int trainingLegs = 0;
int trainingAbs = 0;
int proteinShakeBayers = 0;
int proteinBarBayers = 0;

for (int i = 0; i < visitorsCount; i++)
{
    string activity = Console.ReadLine();

    switch (activity)
    {
        case "Back": trainingBack++; break;
        case "Chest": trainingChest++; break;
        case "Legs": trainingLegs++; break;
        case "Abs": trainingAbs++; break;
        case "Protein shake": proteinShakeBayers++; break;
        case "Protein bar": proteinBarBayers++; break;
    }
}
int tottalPeople = trainingBack + trainingChest + trainingLegs + trainingAbs;
int proteinBuyers = proteinBarBayers + proteinShakeBayers;
double percentTrainingPeople = ((double)tottalPeople / visitorsCount) * 100;
double peopleBuyingProtein = ((double)proteinBuyers / visitorsCount) * 100;

Console.WriteLine($"{trainingBack} - back");
Console.WriteLine($"{trainingChest} - chest");
Console.WriteLine($"{trainingLegs} - legs");
Console.WriteLine($"{trainingAbs} - abs");
Console.WriteLine($"{proteinShakeBayers} - protein shake");
Console.WriteLine($"{proteinBarBayers} - protein bar");
Console.WriteLine($"{percentTrainingPeople:f2}% - work out");
Console.WriteLine($"{peopleBuyingProtein:f2}% - protein");