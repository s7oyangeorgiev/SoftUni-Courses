
int tabsCount = int.Parse(Console.ReadLine());
double salary = double.Parse(Console.ReadLine());

for (int i = 0; i < tabsCount; i++)
{
    string tabsName = Console.ReadLine();

    if (tabsName == "Facebook")
    {
        salary -= 150;
        
    }
    else if (tabsName == "Instagram")
    {
        salary -= 100;
    }
    else if (tabsName == "Reddit")
    {
        salary -= 50;
    }
    if (salary <= 0)
    {
        break;
    }
}
if (salary > 0)
{
    Console.WriteLine($"{salary}");
}
else
{
    Console.WriteLine("You have lost your salary.");
}
