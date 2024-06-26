
int badGrades = int.Parse(Console.ReadLine());

int bagGradesCounter = 0;
double avarageScore = 0;
int taskComplieted = 0;
string lastTask = "";

while (true)
{
    string nameOfTask = Console.ReadLine();

    if (nameOfTask == "Enough")
    {
        Console.WriteLine($"Average score: {avarageScore / taskComplieted:f2}");
        Console.WriteLine($"Number of problems: {taskComplieted}");
        Console.WriteLine($"Last problem: {lastTask}");
        break;
    }
    else
    {
        taskComplieted++;
    }

    int taskAssessment = int.Parse(Console.ReadLine());
        
    if (taskAssessment <= 4)
    {
        bagGradesCounter++;
        avarageScore += taskAssessment;
    }
    else
    {
        avarageScore += taskAssessment;
    }
    if (bagGradesCounter >= badGrades)
    {
        Console.WriteLine($"You need a break, {bagGradesCounter} poor grades.");
        break;
    }
    lastTask = nameOfTask;

}