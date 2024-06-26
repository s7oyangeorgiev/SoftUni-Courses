double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsForOneMeterSwimming = double.Parse(Console.ReadLine());

double timeForAllDistance = distanceInMeters * timeInSecondsForOneMeterSwimming;
double delayTime = Math.Floor(distanceInMeters / 15) * 12.5;
double totalTime = timeForAllDistance + delayTime;

if (recordInSeconds > totalTime)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
}
else
{
    double timeNeededForNewRecord = totalTime - recordInSeconds;
    Console.WriteLine($"No, he failed! He was {timeNeededForNewRecord:f2} seconds slower.");
}
