
string name = Console.ReadLine();

int level = 1;
int badGrades = 0;
double avaregaGrade = 0;

while (level <= 12)
{
    double grade = double.Parse(Console.ReadLine());

    if (grade < 4)
    {
        badGrades++;
    }
    else
    {
        level++;
    }
        avaregaGrade += grade;

    if (badGrades >= 2)
    {
        break;
    }
}
if (badGrades >= 2)
{
    Console.WriteLine($"{name} has been excluded at {level} grade");
}
else
{
    Console.WriteLine($"{name} graduated. Average grade: {avaregaGrade / 12:f2}");
}

