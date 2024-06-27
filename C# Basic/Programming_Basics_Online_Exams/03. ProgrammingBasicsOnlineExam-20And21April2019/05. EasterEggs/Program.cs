
int coloredEggsCount = int.Parse(Console.ReadLine());

int redEggs = 0;
int orangeEggs = 0;
int blueEggs = 0;
int greenEggs = 0;

for (int i = 0; i < coloredEggsCount; i++)
{
    string color = Console.ReadLine();

    switch (color)
    {
        case "red": redEggs += 1; break;
        case "orange": orangeEggs += 1; break;
        case "blue": blueEggs += 1; break;
        case "green": greenEggs += 1; break;
    }
}
Console.WriteLine($"Red eggs: {redEggs}");
Console.WriteLine($"Orange eggs: {orangeEggs}");
Console.WriteLine($"Blue eggs: {blueEggs}");
Console.WriteLine($"Green eggs: {greenEggs}");
if (redEggs > orangeEggs && redEggs > blueEggs && redEggs > greenEggs)
{
    Console.WriteLine($"Max eggs: {redEggs} -> red");
}
else if (orangeEggs > redEggs && orangeEggs > blueEggs && orangeEggs > greenEggs)
{
    Console.WriteLine($"Max eggs: {orangeEggs} -> orange");
}
else if (blueEggs > redEggs && blueEggs > orangeEggs && blueEggs > greenEggs)
{
    Console.WriteLine($"Max eggs: {blueEggs} -> blue");
}
else if (greenEggs > redEggs && greenEggs > orangeEggs && greenEggs > blueEggs)
{
    Console.WriteLine($"Max eggs: {greenEggs} -> green");
}
