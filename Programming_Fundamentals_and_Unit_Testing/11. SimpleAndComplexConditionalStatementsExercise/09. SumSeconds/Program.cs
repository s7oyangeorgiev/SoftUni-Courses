int firstAthleteTimes = int.Parse(Console.ReadLine());
int secondAthleteTime =  int.Parse(Console.ReadLine());
int thirdAthleteTime = int.Parse(Console.ReadLine());

int totalAthletesTime = firstAthleteTimes + secondAthleteTime + thirdAthleteTime;

int totalTimeInMinutes = totalAthletesTime / 60;
double totalTimeInSeconds = totalAthletesTime % 60.00;

if ( totalTimeInSeconds < 10)
{
    Console.WriteLine($"{totalTimeInMinutes}:0{totalTimeInSeconds}");
}
else
{
    Console.WriteLine($"{totalTimeInMinutes}:{totalTimeInSeconds}");
}