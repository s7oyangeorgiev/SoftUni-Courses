string nameOfSerial = Console.ReadLine();
int timeOfEpisode = int.Parse(Console.ReadLine());
int timeForRest = int.Parse(Console.ReadLine());

double timeForLunch = timeForRest / 8.00;
double timeForRecreation = timeForRest / 4.00;
double timeLeft = timeForRest - timeForLunch - timeForRecreation;

if (timeLeft >= timeOfEpisode)
{
    Console.WriteLine($"You have enough time to watch {nameOfSerial} and left with {Math.Ceiling(timeLeft - timeOfEpisode)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {nameOfSerial}, you need {Math.Ceiling(timeOfEpisode - timeLeft)} more minutes.");
}


