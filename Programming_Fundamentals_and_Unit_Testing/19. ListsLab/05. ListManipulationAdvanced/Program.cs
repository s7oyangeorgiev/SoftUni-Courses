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
        case "Contains":
            int numberToCheck = int.Parse(parts[1]);
            if (numbers.Contains(numberToCheck))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            break;

        case "PrintEven":
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", evenNumbers));
            break;

        case "PrintOdd":
            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
            Console.WriteLine(string.Join(" ", oddNumbers));
            break;

        case "GetSum":
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            break;

        case "Filter":
            string condition = parts[1];
            int filterNumber = int.Parse(parts[2]);
            List<int> filteredNumbers = new List<int>();

            switch (condition)
            {
                case "<":
                    filteredNumbers = numbers.Where(n => n < filterNumber).ToList();
                    break;
                case ">":
                    filteredNumbers = numbers.Where(n => n > filterNumber).ToList();
                    break;
                case "<=":
                    filteredNumbers = numbers.Where(n => n <= filterNumber).ToList();
                    break;
                case ">=":
                    filteredNumbers = numbers.Where(n => n >= filterNumber).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid condition");
                    break;
            }

            numbers = filteredNumbers;
            break;

        default:
            Console.WriteLine("Invalid command");
            break;
    }
}
Console.WriteLine(string.Join(" ", numbers));