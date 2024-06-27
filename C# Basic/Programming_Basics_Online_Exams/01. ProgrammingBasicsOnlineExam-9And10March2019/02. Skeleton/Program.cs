
int controlaMinutes = int.Parse(Console.ReadLine());
int controlaSeconds = int.Parse(Console.ReadLine());
double lenght = double.Parse(Console.ReadLine());
double secondsForOneMeter = double.Parse(Console.ReadLine());

double controlaInSeconds = controlaMinutes * 60 + controlaSeconds;
double howManyTimesTimeToBeDown = lenght / 120;
double downTimes = howManyTimesTimeToBeDown * 2.5;

double MartinTime = (lenght / 100) * secondsForOneMeter - downTimes;

if (MartinTime <= controlaInSeconds)
{
    Console.WriteLine("Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {MartinTime:f3}.");
}
else
{
    Console.WriteLine($"No, Marin failed! He was {Math.Abs(controlaInSeconds - MartinTime):f3} second slower.");
}

