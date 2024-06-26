string[] daysOfTheWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

int days = int.Parse(Console.ReadLine());

if (days < 1 || days > 7)
{
    Console.WriteLine("Invalid day!");
    return;
}
Console.WriteLine(daysOfTheWeek[days-1]);