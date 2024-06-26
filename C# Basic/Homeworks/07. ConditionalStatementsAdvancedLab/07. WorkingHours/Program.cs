int number = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (number >= 10 && number <= 18)
{
    switch (day)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            Console.WriteLine("open");
            break;
        default: Console.WriteLine("closed"); break;
    }
}
else
{
    Console.WriteLine("closed");
}