int peopleInJury = int.Parse(Console.ReadLine());

double allPresentationTottalGrade = 0;
int presentationCount = 0;

while (true)
{
    string nameOfPresentation = Console.ReadLine();

    if (nameOfPresentation == "Finish")
    {
        break;
    }
    presentationCount++;

    double tottalGrade = 0;

    for (int i = 0; i < peopleInJury; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        tottalGrade += grade;

    }

    double avaragePresentationGrade = tottalGrade / peopleInJury;
    allPresentationTottalGrade += avaragePresentationGrade;
    Console.WriteLine($"{nameOfPresentation} - {avaragePresentationGrade:f2}.");
}
Console.WriteLine($"Student's final assessment is {allPresentationTottalGrade / presentationCount:f2}.");





