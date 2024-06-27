
int easterBreadCount = int.Parse(Console.ReadLine());

int tottalPoints = 0;
string bestCoocker = "";
int maxPoints = int.MinValue;
int coockerCount = 0;

for (int i = 0; i < easterBreadCount; i++)
{
    string nameOfCoocker = Console.ReadLine();
    coockerCount++;

    while (nameOfCoocker != "Stop")
    {
        string grade = Console.ReadLine();

        while (grade != "Stop")
        {
            int currentGrade = int.Parse(grade);

            tottalPoints += currentGrade;

            grade = Console.ReadLine();
        }
        if (grade == "Stop")
        {
            Console.WriteLine($"{nameOfCoocker} has {tottalPoints} points.");

            if (tottalPoints > maxPoints)
            {
                maxPoints = tottalPoints;
                bestCoocker = nameOfCoocker;
                Console.WriteLine($"{bestCoocker} is the new number 1!");
            }
            tottalPoints = 0;
            break;
        }
    }
    if (coockerCount == easterBreadCount)
    {
        Console.WriteLine($"{bestCoocker} won competition with {maxPoints} points!");
        break;
    }
}