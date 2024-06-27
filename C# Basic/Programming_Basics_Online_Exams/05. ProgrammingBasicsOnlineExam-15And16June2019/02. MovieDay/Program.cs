
int timeForPictures = int.Parse(Console.ReadLine());
int scenesQuantity =  int.Parse(Console.ReadLine());
int timeOfScenes = int.Parse(Console.ReadLine());

double timeForPreparation = timeForPictures * 0.15;
int timeForRecordinfOfScenes = scenesQuantity * timeOfScenes;
double neededTime = timeForPreparation + timeForRecordinfOfScenes;

if (neededTime <= timeForPictures)
{
    Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForPictures - neededTime)} minutes left!");
}
else
{
    Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(neededTime - timeForPictures)} minutes.");
}