
int movieCount = int.Parse(Console.ReadLine());

double maxReiting = double.MinValue;
double minReiting = double.MaxValue;
string nameOfMovieWithMaxReiting = "";
string nameOfMovieWithMinReiting = "";
double avarageSum = 0;

for (int i = 0; i < movieCount; i++)
{
    string name = Console.ReadLine();
    double reiting = double.Parse(Console.ReadLine());
    avarageSum += reiting;

    if (reiting > maxReiting)
    {
        nameOfMovieWithMaxReiting = name;
        maxReiting = reiting;
    }
    if (reiting < minReiting)
    {
        nameOfMovieWithMinReiting = name;
        minReiting = reiting;
    }
}
double avarageReiting = avarageSum / movieCount;

Console.WriteLine($"{nameOfMovieWithMaxReiting} is with highest rating: {maxReiting:f1}");
Console.WriteLine($"{nameOfMovieWithMinReiting} is with lowest rating: {minReiting:f1}");
Console.WriteLine($"Average rating: {avarageReiting:f1}");
