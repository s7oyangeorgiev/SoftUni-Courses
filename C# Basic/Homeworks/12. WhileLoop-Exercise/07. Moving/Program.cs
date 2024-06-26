
int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int hight = int.Parse(Console.ReadLine());

int volume = width * lenght * hight;
int oneBox = 1;

while (volume > 0)
{
    string command = Console.ReadLine();

    if (command == "Done")
    {
        break;
    }
    else
    {
        int boxesCount = int.Parse(command);
        volume -= boxesCount;
    }
}
if (volume > 0)
{
    Console.WriteLine($"{volume} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
}