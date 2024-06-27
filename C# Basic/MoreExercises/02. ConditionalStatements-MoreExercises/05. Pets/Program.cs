//input

int days = int.Parse(Console.ReadLine());
int foodLeftInKg = int.Parse(Console.ReadLine());
double foodForDogPerDayInKg = double.Parse(Console.ReadLine());
double foodForCatPerDayInKg = double.Parse(Console.ReadLine());
double foodForTurtlePerDayInGrams = double.Parse(Console.ReadLine());

//calculations
double foodNeededForDog = days * foodForDogPerDayInKg;
double foodNeededForCat = days * foodForCatPerDayInKg;
double foodNeededForTurtle = (days * foodForTurtlePerDayInGrams) / 1000;
double totalFoodNeeded = foodNeededForDog + foodNeededForCat + foodNeededForTurtle;

//output
if (foodLeftInKg >= totalFoodNeeded)
{
    double foodRemainder = foodLeftInKg - totalFoodNeeded;
    Console.WriteLine($"{Math.Floor(foodRemainder)} kilos of food left.");
}
else
{
    double foodNeeded = totalFoodNeeded - foodLeftInKg;
    Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
}