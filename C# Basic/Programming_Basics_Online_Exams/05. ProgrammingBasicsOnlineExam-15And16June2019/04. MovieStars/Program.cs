
double budget = double.Parse(Console.ReadLine());
string command = Console.ReadLine();

double salary = 0;

while (command != "ACTION")
{
    int stringLenght = command.Length;
    
    if (stringLenght <= 15)
    {
        salary = double.Parse(Console.ReadLine());
        budget -= salary;
    }
    else
    {
        salary = budget * 0.20;
        budget -= salary;
    }

    if (budget <= 0)
    {
        break;
    }
    command = Console.ReadLine();
}
if (budget < 0)
{
    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
}
else
{
    Console.WriteLine($"We are left with {budget:f2} leva.");
}