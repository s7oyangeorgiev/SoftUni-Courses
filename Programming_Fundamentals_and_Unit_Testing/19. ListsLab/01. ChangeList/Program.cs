List<int> listOfNumbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    string[] partsOfCommand = command.Split(" ");

    if (partsOfCommand[0] == "Delete")
    {
        int element = int.Parse(partsOfCommand[1]);
        listOfNumbers.RemoveAll(e => e == element);
    }
    else if (partsOfCommand[0] == "Insert")
    {
        int element = int.Parse(partsOfCommand[1]);
        int position = int.Parse(partsOfCommand[2]);
        if (position >= 0 && position <= listOfNumbers.Count)
        {
            listOfNumbers.Insert(position, element);
        }
    }
}
Console.WriteLine(string.Join(" ", listOfNumbers));