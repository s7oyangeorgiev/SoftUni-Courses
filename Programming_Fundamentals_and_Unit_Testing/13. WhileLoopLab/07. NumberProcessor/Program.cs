int num = int.Parse(Console.ReadLine());

int lastNum = num;

while (true)
{
    string command = Console.ReadLine();

    if ( command == "Inc")
    {
        lastNum += 1;
        continue;
    }
    else if ( command == "Dec")
    {
        lastNum -= 1;
        continue;
    }
    else if (command == "End")
    {
        Console.WriteLine(lastNum);
        break;
    }
}

