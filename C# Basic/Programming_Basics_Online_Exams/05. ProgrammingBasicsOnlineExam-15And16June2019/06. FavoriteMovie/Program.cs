
int pointsForCurrentMovie = 0;
int movieCounter = 0;
int maxPointsForMovie = int.MinValue;
string theBestMovie = "";

while (true)
{
    string nameOfMovie = Console.ReadLine();
    
    if (nameOfMovie == "STOP")
    {
        break;
    }
    movieCounter++;
    pointsForCurrentMovie = 0;

    for (int i = 0; i < nameOfMovie.Length; i++)
    {
        char character = nameOfMovie[i];
        pointsForCurrentMovie += character;

        if (character >= 'a' && character <= 'z')
        {
            pointsForCurrentMovie -= 2 * nameOfMovie.Length;
        }
        if (character >= 'A' && character <= 'Z')
        {
            pointsForCurrentMovie -= nameOfMovie.Length;
        }
    }

    if (pointsForCurrentMovie > maxPointsForMovie)
    {
        maxPointsForMovie = pointsForCurrentMovie;
        theBestMovie = nameOfMovie;
    }

    if (movieCounter >= 7)
    {
        break;
    }
}

if (movieCounter >= 7)
{
    Console.WriteLine("The limit is reached.");
    Console.WriteLine($"The best movie for you is {theBestMovie} with {maxPointsForMovie} ASCII sum.");
}
else
{
    Console.WriteLine($"The best movie for you is {theBestMovie} with {maxPointsForMovie} ASCII sum.");
}