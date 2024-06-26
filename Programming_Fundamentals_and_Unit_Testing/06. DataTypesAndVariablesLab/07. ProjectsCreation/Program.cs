string architectureName = Console.ReadLine();
int countOfProjects = int.Parse(Console.ReadLine());

double projectsHoursNeeded = countOfProjects * 3;

Console.WriteLine($"The architect {architectureName} will need {projectsHoursNeeded} hours " +
    $"to complete {countOfProjects} project/s.");
