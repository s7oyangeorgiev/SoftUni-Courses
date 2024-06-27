
using System.Transactions;

int minutesPerDay = int.Parse(Console.ReadLine());
int numbersPerDay =  int.Parse(Console.ReadLine());
int consumedCalories = int.Parse(Console.ReadLine());

int tottalMinutesPerDay = numbersPerDay * minutesPerDay;
double tottalBurnCalories = tottalMinutesPerDay * 5;
double consumedCaloriesPerDay = consumedCalories * 0.5;

if (tottalBurnCalories >= consumedCaloriesPerDay)
{
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {tottalBurnCalories}.");
}
else
{
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {tottalBurnCalories}.");
}