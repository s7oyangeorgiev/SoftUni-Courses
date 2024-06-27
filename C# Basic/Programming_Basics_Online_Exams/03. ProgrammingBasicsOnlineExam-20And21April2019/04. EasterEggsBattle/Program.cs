
int eggsOfFirstPlayerCount = int.Parse(Console.ReadLine());
int eggsOfSecondPlayerCount = int.Parse(Console.ReadLine());

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        Console.WriteLine($"Player one has {eggsOfFirstPlayerCount} eggs left.");
        Console.WriteLine($"Player two has {eggsOfSecondPlayerCount} eggs left.");
        break;
    }

    if (command == "one")
    {
        eggsOfSecondPlayerCount -= 1;
        
    }
    else
    {
        eggsOfFirstPlayerCount -= 1;
        
    }

    if (eggsOfFirstPlayerCount == 0)
    {
        Console.WriteLine($"Player one is out of eggs. Player two has {eggsOfSecondPlayerCount} eggs left.");
        break;
    }
    else if (eggsOfSecondPlayerCount == 0)
    {
        Console.WriteLine($"Player two is out of eggs. Player one has {eggsOfFirstPlayerCount} eggs left.");
        break;
    }
}
