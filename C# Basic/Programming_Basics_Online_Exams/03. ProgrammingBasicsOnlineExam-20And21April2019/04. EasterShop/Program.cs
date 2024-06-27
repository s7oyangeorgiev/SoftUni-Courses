
int eggsCountInTheShop = int.Parse(Console.ReadLine());

int sellingEggs = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "Close")
    {
        Console.WriteLine("Store is closed!");
        Console.WriteLine($"{sellingEggs} eggs sold.");
        break;
    }
    
    int eggsCount = int.Parse(Console.ReadLine());
    if (command == "Buy" && eggsCount > eggsCountInTheShop)
    {
        Console.WriteLine($"Not enough eggs in store!");
        Console.WriteLine($"You can buy only {eggsCountInTheShop}.");
        break;
    }
    else if (command == "Fill")
    {
        eggsCountInTheShop += eggsCount;
    }
    else if (command == "Buy")
    {
        eggsCountInTheShop -= eggsCount;
        sellingEggs += eggsCount;
    }

}