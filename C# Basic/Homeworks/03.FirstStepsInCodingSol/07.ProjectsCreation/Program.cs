string name = Console.ReadLine();
int project = int.Parse(Console.ReadLine());

int timeNeeded = project * 3;

Console.WriteLine($"The architect {name} will need {timeNeeded} hours to complete {project} project/s.");