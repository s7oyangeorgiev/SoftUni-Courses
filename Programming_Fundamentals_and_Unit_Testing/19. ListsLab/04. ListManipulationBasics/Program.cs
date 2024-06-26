    List<int> numbers = Console.ReadLine()
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

        string[] parts = command.Split(" ");

        switch (parts[0])
        {
            case "Add":
                int numberToAdd = int.Parse(parts[1]);
                numbers.Add(numberToAdd);
                break;

            case "Remove":
                int numberToRemove = int.Parse(parts[1]);
                numbers.Remove(numberToRemove);
                break;

            case "RemoveAt":
                int indexToRemoveAt = int.Parse(parts[1]);
                numbers.RemoveAt(indexToRemoveAt);
                break;

            case "Insert":
                int numberToInsert = int.Parse(parts[1]);
                int indexToInsertAt = int.Parse(parts[2]);
                numbers.Insert(indexToInsertAt, numberToInsert);
                break;

            default:
                Console.WriteLine("Invalid command");
                break;
        }
    }
    Console.WriteLine(string.Join(" ", numbers));