
double record = double.Parse(Console.ReadLine());
double distanceInMeters =  double.Parse(Console.ReadLine());
double timeInSecondsFor1m = double.Parse(Console.ReadLine());

double time = distanceInMeters * timeInSecondsFor1m;
double delay = Math.Floor((distanceInMeters / 50)) * 30;
double tottalTime = time + delay;

if (record > tottalTime)
{
    Console.WriteLine($"Yes! The new record is {tottalTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No! He was {tottalTime - record:f2} seconds slower.");
}