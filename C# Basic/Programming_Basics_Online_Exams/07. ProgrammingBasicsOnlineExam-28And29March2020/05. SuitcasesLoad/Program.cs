
double bagCapacity = double.Parse(Console.ReadLine());
string command = Console.ReadLine();

int suitcaseCounter = 0;
bool isFull = false;

while (command != "End")
{
    double suitcaseVolume = double.Parse(command);
    suitcaseCounter++;

    if (suitcaseCounter % 3 == 0)
    {
        suitcaseVolume = suitcaseVolume + (suitcaseVolume * 0.10);
    }
    if (bagCapacity < suitcaseVolume)
    {
        suitcaseCounter--;
        isFull = true;
        break;
    }

    bagCapacity -= suitcaseVolume;
    
    command = Console.ReadLine();
}
if (command == "End")
{
    Console.WriteLine("Congratulations! All suitcases are loaded!");
    Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
}
else if (isFull)
{
    Console.WriteLine("No more space!");
    Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
}

