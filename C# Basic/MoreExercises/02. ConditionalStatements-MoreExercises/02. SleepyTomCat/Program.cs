//input
int holidays = int.Parse(Console.ReadLine());

//calculation
double norm = 30000;
double timeForPlayingInHolidays = holidays * 127.00;
double timeForplayingInWorkingDays = (365 - holidays) * 63;
double allTimeForPlaying = timeForplayingInWorkingDays + timeForPlayingInHolidays;

//output
if (allTimeForPlaying > norm)
{
    double differenceFromNorm = allTimeForPlaying - norm;
    double differenceToNormHours = Math.Floor(differenceFromNorm / 60);
    double differenceToNormMinutes = differenceFromNorm % 60;
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{differenceToNormHours} hours and {differenceToNormMinutes} minutes more for play");
}
else
{
    double differenceFromNorm = norm - allTimeForPlaying;
    double differenceToNormHours = Math.Floor(differenceFromNorm / 60);
    double differenceToNormMinutes = differenceFromNorm % 60;
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{differenceToNormHours} hours and {differenceToNormMinutes} minutes less for play") ;
}
